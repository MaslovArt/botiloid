using System.Drawing;
using System;

namespace botiloid.gameBot
{
    class POIData
    {
        public Point pt;
        public string noFiltDist;
        public int dist;
        private static int distRecCorrection = 400;
        public string command;
        public int speed;
        public double fps;

        public POIData(Point pt, string dist)
        {
            this.pt = pt;
            if (dist.Length >= 2)
            {
                this.dist = Convert.ToInt32(dist);
                //if (this.dist > distRecCorrection)
                //    this.dist = Convert.ToInt32(dist.Substring(0, 2));

                if (this.dist < 60)
                    distRecCorrection = 200;
            }
            else {
                this.dist = -1;
                distRecCorrection = 400;
            }


        }
    }
}
