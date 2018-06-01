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
        public int situation;

        public POIData(Point pt, int dist)
        {
            this.pt = pt;
            this.dist = dist;
        }
    }
}
