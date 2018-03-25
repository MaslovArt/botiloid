using System;
using System.Drawing;
using System.Runtime.InteropServices;
using botiloid.gameBot;
using botiloid.Subsidiary;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;

namespace botiloid
{
    class KeyboardBotControl : IBotControl
    {
        /*
        -----------------------------------
        |         |     uReс    |         |
        |         |             |         |
        |  l      |------------ |  r      |
        |  R      |    |   |    |  R      |
        |  e      |esL | C | esR|  e      |
        |  c      |    |   |    |  c      |
        |         |-------------|         |
        |         |     dRec    |         |
        |         |-------------|         |
        |         |ldRec | rdRec|         |
        -----------------------------------
        */
        private Size viewPort;
        private Rectangle uRec, dRec, dlRec, drRec, lRec, esLRec, rRec, esRRec, cRec;
        private byte currentKey = 0;
        private byte com_up, com_down, com_left, com_right, com_esLeft, com_esRight;

        private bool flyUp = false;
        //private int midDist = 0, dcount = 0, midDistMemor = 0;
        private List<byte> curKeys = new List<byte>(5);
        private GlobalVarialbles gv = GlobalVarialbles.Constructor();

        private Stopwatch sw = new Stopwatch();

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        const uint KEYEVENTF_KEYUP = 0x0002;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        public KeyboardBotControl(Size viewPort)
        {
            this.viewPort = viewPort;

            initScreenSpliting();
            initBotCommands();
        }

        private void initScreenSpliting()
        {
            lRec = new Rectangle(new Point(0, 0),
                                 new Size(viewPort.Width / 3, viewPort.Height));
            rRec = new Rectangle(new Point(viewPort.Width - lRec.Width, 0),
                                 lRec.Size);
            uRec = new Rectangle(new Point(lRec.Width, 0),
                                 new Size(viewPort.Width - lRec.Width * 2, viewPort.Height / 3));
            dRec = new Rectangle(new Point(lRec.Width, uRec.Height * 2),
                                 new Size(uRec.Width, uRec.Height / 2));
            dlRec = new Rectangle(new Point(dRec.Location.X, dRec.Location.Y + dRec.Height),
                                  new Size(dRec.Width / 2, dRec.Height));
            drRec = new Rectangle(new Point(dlRec.Location.X + dlRec.Width, dlRec.Y),
                                  dlRec.Size);
            esLRec = new Rectangle(new Point(lRec.Width, uRec.Height),
                                   new Size((uRec.Width / 3), uRec.Height));
            esRRec = new Rectangle(new Point(viewPort.Width - rRec.Width - esLRec.Width, uRec.Height),
                                   esLRec.Size);
            cRec = new Rectangle(new Point(lRec.Width + esLRec.Width, uRec.Height),
                                 new Size(esLRec.Width, uRec.Height));

            //lRec = new Rectangle(new Point(0, 0),
            //                     new Size(viewPort.Width / 3, viewPort.Height));
            //rRec = new Rectangle(new Point(viewPort.Width - lRec.Width, 0),
            //                     lRec.Size);
            //uRec = new Rectangle(new Point(0, 0),
            //                     new Size(viewPort.Width, viewPort.Height / 3));
            //dRec = new Rectangle(new Point(0, uRec.Height * 2),
            //                     new Size(uRec.Width, uRec.Height / 2));
            //dlRec = new Rectangle(new Point(dRec.Location.X, dRec.Location.Y + dRec.Height),
            //                      new Size(dRec.Width / 2, dRec.Height));
            //drRec = new Rectangle(new Point(dlRec.Location.X + dlRec.Width, dlRec.Y),
            //                      dlRec.Size);
            //esLRec = new Rectangle(new Point(lRec.Width, uRec.Height),
            //                       new Size((uRec.Width / 9), uRec.Height));
            //esRRec = new Rectangle(new Point(esLRec.X + esLRec.Width * 2, esLRec.Height),
            //                       esLRec.Size);
            //cRec = new Rectangle(new Point(lRec.Width + esLRec.Width, uRec.Height),
            //                     new Size(esLRec.Width, uRec.Height));

        }
        private void initBotCommands()
        {
            com_down = (byte)gv.botKeys["down"];
            com_up = (byte)gv.botKeys["up"];
            com_left = (byte)gv.botKeys["left"];
            com_right = (byte)gv.botKeys["right"];
            com_esRight = (byte)gv.botKeys["esRight"];
            com_esLeft = (byte)gv.botKeys["esLeft"];
        }

        /// <summary>
        /// Перемещается к точке
        /// </summary>
        /// <param name="obj">poi</param>
        /// <returns></returns>
        public string moveTo(POIData poiDate)
        {
            keybd_event(currentKey, 0, KEYEVENTF_KEYUP, 0);

            if (poiDate == null)
                return "not found";

            var obj = poiDate.pt;
            var command = "";

            if (uRec.Contains(obj))
            {
                currentKey = com_down;
                flyUp = true;
                sw.Restart();
                command = "up";
            }
            else if (dRec.Contains(obj))
            {
                currentKey = com_up;
                command = "down";
            }
            else if (lRec.Contains(obj) || dlRec.Contains(obj))
            {
                currentKey = com_left;
                command = "left";
            }
            else if (esLRec.Contains(obj))
            {
                currentKey = com_esLeft;
                command = "easy-left";
            }
            else if (rRec.Contains(obj) || drRec.Contains(obj))
            {
                currentKey = com_right;
                command = "right";
            }
            else if (esRRec.Contains(obj))
            {
                currentKey = com_esRight;
                command = "easy-right";
            }
            else if (cRec.Contains(obj))
            {
                command = "straight";
                return command;
            }

            keybd_event(currentKey, 0, 0, 0);

            if (currentKey != com_down)
                if (flyUp && sw.ElapsedMilliseconds < 300)
                    keybd_event(com_down, 0, 0, 0);
                else
                {
                    flyUp = false;
                    keybd_event(com_down, 0, KEYEVENTF_KEYUP, 0);
                }
        

            //int dist = 0;
            //if (poiDate.dist.Length > 0)
            //{
            //    dist = Convert.ToInt32(poiDate.dist);
            //    midDist += dist;
            //    if (++dcount > 30)
            //    {
            //        dcount = 0;
            //        midDistMemor = midDist / 30;
            //    }
            //}
            //poiDate.midDist = midDistMemor;


            return command;
        }

        /// <summary>
        /// Отменяет последнюю команду
        /// </summary>
        public void release()
        {
            keybd_event(currentKey, 0, KEYEVENTF_KEYUP, 0);
            //foreach (var item in curKeys)
            //    keybd_event(item, 0, KEYEVENTF_KEYUP, 0);
        }

        #region tests
        public string moveTo2(POIData poiDate)
        {
            foreach (var item in curKeys)
                keybd_event(item, 0, KEYEVENTF_KEYUP, 0);

            if (poiDate == null)
                return "not found";

            curKeys.Clear();

            var obj = poiDate.pt;
            //if (flyUp)
            //    upCorrection++;

            var repCommands = "";
            if (cRec.Contains(obj))
            {
                curKeys.Clear();
                repCommands = "straight";
            }
            else
            {
                if (uRec.Contains(obj))
                {
                    flyUp = true;
                    curKeys.Add(com_down);
                    repCommands += "up ";
                }
                else if (dRec.Contains(obj))
                {
                    curKeys.Add(com_up);
                    repCommands += "down ";
                }
                if (lRec.Contains(obj) || dlRec.Contains(obj))
                {
                    curKeys.Add(com_left);
                    repCommands += "left ";
                }
                else if (rRec.Contains(obj) || drRec.Contains(obj))
                {
                    curKeys.Add(com_right);
                    repCommands += "right ";
                }
                if (esLRec.Contains(obj))
                {
                    curKeys.Add(com_esLeft);
                    repCommands += "easy-left ";
                }
                else if (esRRec.Contains(obj))
                {
                    curKeys.Add(com_esRight);
                    repCommands += "easy-right ";
                }
            }

            //if(flyUp && upCorrection < 15 && !curKeys.Contains(com_up))
            //{
            //    curKeys.Add(com_up);
            //    upCorrection = 0;
            //    flyUp = false;
            //}


            foreach (var item in curKeys)
                keybd_event(item, 0, 0, 0);

            return repCommands;
        }
    
        #endregion

    }
}
