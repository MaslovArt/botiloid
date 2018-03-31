using System.Drawing;
using System;

namespace botiloid.gameBot
{
    class POIData
    {
        public Point pt;
        public int dist;
        public string command;
        public int speed;
        public double fps;

        public POIData(Point pt, string dist)
        {
            this.pt = pt;
            try
            {
                this.dist = Convert.ToInt32(dist);
            }
            catch (Exception)
            {
                this.dist = -1;
            }
            
        }
    }
}
