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
        private string filtDist = "";
        private string noFiltDist = "";

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

            if (rec.Width > 0)
            {
                if (++distReqest > 20)
                {
                    filtDist = recognizeSpeed(rec, processedFrameSt);
                    if (filtDist.Length > 1)
                        distReqest = 0;
                }
                var pd = new POIData(rec.Location, filtDist);
                pd.noFiltDist = noFiltDist;
                return pd;
            }
            return null;
        }

        private string recognizeSpeed(Rectangle rec, Image<Gray, byte> processedFrameSt)
        {
            Rectangle roi = new Rectangle(new Point(rec.Location.X - 1, rec.Location.Y - 3), new Size(27, 14));
            var imPart = processedFrameSt;
            imPart.ROI = roi;
            imPart = imPart.Copy();
            imPart = imPart.SmoothGaussian(1);
            filtDist = "";
            if (tess != null)
            {
                tess.SetImage(imPart);
                tess.Recognize();
                var t = tess.GetUTF8Text();
                noFiltDist = t;
                for (int i = 0; i < t.Length; i++)
                {
                    if ((int)t[i] > 47 && (int)t[i] < 58)
                        filtDist += t[i];
                }
            }
            else {
                filtDist = string.Empty;
            }
            return filtDist;
        }
    }
}
