using botiloid.Subsidiary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Timers;

namespace botiloid.gameBot
{
    class KeyboardTimerBotControl : IBotControl
    {
        private class keyPresser : IComparable
        {
            public byte code;
            public int times;

            public keyPresser()
            {
                code = 0;
                times = -1;
            }
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

            public override bool Equals(object obj)
            {
                return code == ((keyPresser)obj).code;
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }

        private Size viewPort;
        private Point scCenter; 
        private byte com_up, com_down, com_left, com_right, com_esLeft, com_esRight;

        private int lowSpeedCor = 0;
        private int cor_pitch = 100, cor_roll = 100, cor_yaw = 40;
        private int rollStep, pitchStep;

        private List<byte> curKeys = new List<byte>(3);
        private GlobalVarialbles gv = GlobalVarialbles.Constructor();

        private Timer timer;
        private List<keyPresser> currentCmds = new List<keyPresser>(3);

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        const uint KEYEVENTF_KEYUP = 0x0002;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        public KeyboardTimerBotControl(Size viewPort)
        {
            this.viewPort = viewPort;
            initBotCommands();
            scCenter = new Point(viewPort.Width / 2, viewPort.Height / 2);

            rollStep = viewPort.Width / 8;
            pitchStep = viewPort.Height / 5;
            timer = new Timer(70);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            foreach (var cmd in currentCmds)
                if(--cmd.times < 1)
                    if (currentCmds.Remove(cmd))
                        keybd_event(cmd.code, 0, KEYEVENTF_KEYUP, 0);
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
            var command = string.Empty;

            //yaw correction
            if (lowSpeedCor == 5)
            {
                if (obj.X > scCenter.X + cor_yaw && obj.X < scCenter.X + cor_roll)
                {
                    command = "yaw-right ";
                    putCmd(com_esRight, 3);
                }
                else if (obj.X < scCenter.X - cor_yaw && obj.X > scCenter.X - cor_roll)
                {
                    command = "yaw-left ";
                    putCmd(com_esLeft, 3);
                }
            }

            //roll correction
            if (obj.X > scCenter.X + cor_roll ||
               (obj.X > scCenter.X && obj.Y > viewPort.Height - 60))
            {
                var moveTime = Math.Abs(scCenter.X - obj.X) / rollStep > 2
                               ? 3
                               : 1;
                command += "right" + moveTime + " ";
                putCmd(com_right, moveTime);
            }
            else if (obj.X < scCenter.X - cor_roll ||
                     (obj.X < scCenter.X && obj.Y > viewPort.Height - 60))
            {
                var moveTime = Math.Abs(scCenter.X - obj.X) / rollStep > 2
                               ? 3
                               : 1;
                command += "left" + moveTime + " ";
                putCmd(com_left, moveTime);
            }

            //pitch correction
            if ((obj.X > 120 && obj.X < viewPort.Width - 120 &&
                obj.Y < viewPort.Height - 60))
            {
                if (obj.Y > scCenter.Y + cor_pitch)
                {
                    command += "down ";
                    putOrUpdateCmd(com_up, 5);
                }
                else if (obj.Y < scCenter.Y - cor_pitch)
                {
                    command += "up ";
                    putOrUpdateCmd(com_down, 5 + lowSpeedCor);
                }
            }

            //speed correction
            if (obj.X < 10 || obj.X > viewPort.Width - 10 ||
                obj.Y < 10 || obj.Y > viewPort.Height - 10)
            { poiDate.speed = 100; lowSpeedCor = 0; }
            else
            {
                if (poiDate.dist >= 90)
                { poiDate.speed = 100; lowSpeedCor = 0; }
                else if (poiDate.dist >= 70 && poiDate.dist < 80)
                { poiDate.speed = 75; lowSpeedCor = 1; }
                else if (poiDate.dist >= 50 && poiDate.dist < 60)
                { poiDate.speed = 50; lowSpeedCor = 3; }
                else if (poiDate.dist >= 10 && poiDate.dist < 40)
                { poiDate.speed = 30; lowSpeedCor = 5; }
            }

            if (command == string.Empty)
                command = "streight";

            return command;
        }

        private void putCmd(byte code, int moveTime)
        {
            var newCmd = new keyPresser(code, moveTime);
            if (currentCmds.Contains(newCmd))
                return;
            currentCmds.Add(newCmd);
            keybd_event(code, 0, 0, 0);
        }
        private void putOrUpdateCmd(byte code, int moveTime)
        {
            for (int i = 0; i < currentCmds.Count; i++)
                if (currentCmds[i].code == code)
                {
                    currentCmds[i].times = moveTime;
                    return;
                }
            putCmd(code, moveTime);
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
