using System.Drawing;

namespace botiloid
{
    class POIData
    {
        public Point pt;
        public string dist;
        public int midDist;
        public string command;
        public double fps;
        public Bitmap test;

        public POIData(Point pt, string dist)
        {
            this.pt = pt;
            this.dist = dist;
        }
    }
}
