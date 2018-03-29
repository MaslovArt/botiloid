using botiloid.Subsidiary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace botiloid.gameBot
{
    class KeyboardTimerBotControl : IBotControl
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

        private class keyPresser : IComparable
        {
            public byte code;
            public int times;

            public keyPresser(byte code, int times)
            {
                this.code = code;
                this.times = times;
            }

            public int CompareTo(object obj)
            {
                var _obj = (keyPresser)obj;
                return code - _obj.code;
            }
        }

        private Size viewPort;
        private Rectangle uRec, dRec, dlRec, drRec, lRec, esLRec, rRec, esRRec, cRec;
        private byte currentKey = 0;
        private byte com_up, com_down, com_left, com_right, com_esLeft, com_esRight;

        private List<byte> curKeys = new List<byte>(5);
        private GlobalVarialbles gv = GlobalVarialbles.Constructor();

        private Timer timer;
        private HashSet<keyPresser> currentCmds = new HashSet<keyPresser>();

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        const uint KEYEVENTF_KEYUP = 0x0002;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        public KeyboardTimerBotControl(Size viewPort)
        {
            this.viewPort = viewPort;

            initScreenSpliting();
            initBotCommands();

            timer = new Timer(70);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            foreach (var cmd in currentCmds)
            {
                if(--cmd.times < 1)
                {
                    keybd_event(currentKey, 0, KEYEVENTF_KEYUP, 0);
                    currentCmds.Remove(cmd);
                }
            }
        }

        private void initScreenSpliting()
        {
            lRec = new Rectangle(new Point(0, 0),
                                 new Size(viewPort.Width / 4, viewPort.Height));
            rRec = new Rectangle(new Point(viewPort.Width - lRec.Width, 0),
                                 lRec.Size);
            uRec = new Rectangle(new Point(lRec.Width, 0),
                                 new Size(viewPort.Width - lRec.Width * 2, viewPort.Height / 3));
            dRec = new Rectangle(new Point(lRec.Width, uRec.Height * 2),
                                 new Size(uRec.Width, uRec.Height / 2));
            dlRec = new Rectangle(new Point(dRec.Location.X, dRec.Bottom),
                                  new Size(dRec.Width / 2, dRec.Height));
            drRec = new Rectangle(new Point(dlRec.Right, dlRec.Y),
                                  dlRec.Size);
            esLRec = new Rectangle(new Point(lRec.Width, uRec.Height),
                                   new Size((uRec.Width / 3), uRec.Height));
            esRRec = new Rectangle(new Point(viewPort.Width - rRec.Width - esLRec.Width, uRec.Height),
                                   esLRec.Size);
            cRec = new Rectangle(new Point(lRec.Width + esLRec.Width, uRec.Height),
                                 new Size(esLRec.Width, uRec.Height));
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
            if (poiDate == null)
                return "not found";

            if (!timer.Enabled)
                timer.Enabled = true;

            var obj = poiDate.pt;
            var command = "";

            if (uRec.Contains(obj))
            {
                currentKey = com_down;
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

            currentCmds.Add(new keyPresser(currentKey, 1));
            keybd_event(currentKey, 0, 0, 0);

            return command;
        }

        /// <summary>
        /// Отменяет последнюю команду
        /// </summary>
        public void release()
        {
            if (timer != null)
                timer.Enabled = false;

            foreach (var item in currentCmds)
                keybd_event(item.code, 0, KEYEVENTF_KEYUP, 0);
        }
    }
}
