using System.Collections.Generic;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Tesseract;
using System.Drawing;
using System;

namespace botiloid
{
    class BotCV
    {
        private int Hmin, Smin, Vmin, Hmax, Smax, Vmax;
        private TesseractEngine tess;
        private ScreenCapture sc;
        private IntPtr winDiscript;

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

            tess = new TesseractEngine(@"tessdata", "eng", EngineMode.Default);
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
        /// <param name="processedFrame"></param>
        /// <returns>Координаты объекта</returns>
        public POIData detectObj(out Bitmap fr)
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
                Rectangle roi = new Rectangle(new Point(rec.Location.X - 1, rec.Location.Y - 3), new Size(27, 14));
                var imPart = processedFrameSt;
                imPart.ROI = roi;
                imPart = imPart.Copy();
                imPart = imPart.SmoothGaussian(1);
                using (var page = tess.Process(imPart.ToBitmap()))
                {
                    var dist = page.GetText();
                    var filtDist = "";
                    for(int i = 0; i < dist.Length; i++)
                    {
                        if ((int)dist[i] > 47 && (int)dist[i] < 58 || (int)dist[i] == 46)
                            filtDist += dist[i];
                    }
                    var pd = new POIData(rec.Location, filtDist);
                    fr = imPart.ToBitmap();
                    return pd;
                }
            }
            fr = null;
            return null;
        }
    }
}
