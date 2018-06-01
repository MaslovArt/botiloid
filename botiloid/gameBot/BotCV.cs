using System.Collections.Generic;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.OCR;
using System.Drawing;
using System;

namespace botiloid.gameBot
{
    class BotCV
    {
        private int Hmin, Smin, Vmin, Hmax, Smax, Vmax;
        private Emgu.CV.OCR.Tesseract tess;
        private ScreenCapture sc;
        private IntPtr winDiscript;
        private int distReqest = 0;
        private int filtDist = -1;
        private int situation;
        private int prevDist = 0;
        private string noFiltDist = "";
        private Rectangle recWhenBigDist = new Rectangle();
        private bool distLess100 = false, distLess40 = false;

        public BotCV(IntPtr win, int Hmin, int Smin, int Vmin, int Hmax, int Smax, int Vmax)
        {
            this.Hmin = Hmin;
            this.Hmax = Hmax;
            this.Smin = Smin;
            this.Smax = Smax;
            this.Vmin = Vmin;
            this.Vmax = Vmax;

            sc = new ScreenCapture();
            winDiscript = win;

            try
            {
                tess = new Emgu.CV.OCR.Tesseract(@"", "eng", OcrEngineMode.TesseractOnly);
                tess.SetVariable("tessedit_char_whitelist", ".0123456789");
            }
            catch (Exception te)
            {
                Console.WriteLine(te.Message);
                tess = null;
            }
        }

        public Size ViewPort
        {
            get { return sc.PrintWindow(winDiscript).Size; }
        }

        /// <summary>
        /// Фильтр изображения по цвету
        /// </summary>
        /// <param name="frame"></param>
        /// <returns></returns>
        public Image<Gray, byte> ProcessImage(Bitmap frame)
        {
            using (Image<Hsv, byte> imHsv = new Image<Hsv, byte>(frame))
            {
                Image<Gray, byte>[] hsvChannels;
                hsvChannels = imHsv.Split();
                using (var imHue = hsvChannels[0])
                using (var imS = hsvChannels[1])
                using (var imV = hsvChannels[2])
                {
                    return imHue.InRange(new Gray(Hmin), new Gray(Hmax)).And(
                             imS.InRange(new Gray(Smin), new Gray(Smax))).And(
                             imV.InRange(new Gray(Vmin), new Gray(Vmax)));
                }
            }
        }

        /// <summary>
        /// Находит объект
        /// </summary>
        /// <returns>Возвращает координаты объекта. Если оюъект не найден возвращает null.</returns>
        public POIData detectObj()
        {
            var frame = sc.PrintWindow(winDiscript);
            var processedFrameSt = ProcessImage(frame);
            var processedFrame = processedFrameSt.Canny(180, 120);
            List<PointF> pList = new List<PointF>();
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(processedFrame, contours, null, RetrType.External, ChainApproxMethod.ChainApproxSimple);
                int count = contours.Size;
                for (int i = 0; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    using (VectorOfPoint approxContour = new VectorOfPoint())
                    {
                        CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);
                        double area = CvInvoke.ContourArea(approxContour, false);
                        for (int k = 0; k < approxContour.Size; k++)
                            pList.Add(approxContour[k]);
                    }
                }
            }
            var rec = PointCollection.BoundingRectangle(pList.ToArray());
            if (recWhenBigDist.IsEmpty)
                recWhenBigDist = rec;

            if (recWhenBigDist.Width - rec.Width > 3)
                distLess100 = true;
            else distLess100 = false;

            if (rec.Width > 0)
            {
                if (++distReqest > 20)
                {
                    filtDist = recognizeSpeed(rec, processedFrameSt);
                    if (filtDist > 1)
                    {
                        distReqest = 0;
                        if (prevDist - filtDist >= 15)
                            situation = 1;
                        if (Math.Abs(prevDist - filtDist) > 1 && Math.Abs(prevDist - filtDist) < 15)
                            situation = 2;
                        prevDist = filtDist;
                    }
                    else
                    {
                        if (distLess40)
                            situation = 3;
                    }
                }
                var pd = new POIData(rec.Location, filtDist);
                distLess40 = filtDist < 40;
                pd.noFiltDist = noFiltDist;
                pd.situation = situation;

                return pd;
            }
            return null;
        }

        private int recognizeSpeed(Rectangle rec, Image<Gray, byte> processedFrameSt)
        {
            Rectangle roi = new Rectangle(new Point(rec.Location.X, rec.Location.Y - 2), new Size(20, 14));
            var imPart = processedFrameSt;
            imPart.ROI = roi;
            imPart = imPart.Copy();
            //imPart = imPart.SmoothGaussian(1);
            string tempDist = "";
            if (tess != null)
            {
                tess.SetImage(imPart);
                tess.Recognize();

                noFiltDist = tess.GetUTF8Text();
                for (int i = 0; i < noFiltDist.Length; i++)
                {
                    if ((int)noFiltDist[i] > 47 && (int)noFiltDist[i] < 58)
                        tempDist += noFiltDist[i];
                }
            }
            else {
                return -666;
            }
            if (tempDist.Length >= 2)
            {
                if (distLess100)
                    tempDist = tempDist.Substring(0, 2);
                filtDist = Convert.ToInt32(tempDist);
            }
            else filtDist = -1;

            return filtDist;
        }
    }
}
