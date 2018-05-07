using System.Drawing;
using System;

namespace botiloid.gameBot
{
    class POIData
    {
        public Point pt;
        public string noFiltDist;
        public int dist;
        public string command;
        public int speed;
        public double fps;

        public POIData(Point pt, string dist)
        {
            this.pt = pt;

            if (dist.Length >= 2)
                this.dist = Convert.ToInt32(dist);
            else
                this.dist = -1;

        }
    }
}
