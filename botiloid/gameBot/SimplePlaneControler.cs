using System.Collections.Generic;
using System.Runtime.InteropServices;
using botiloid.Subsidiary;
using System.Timers;

namespace botiloid.gameBot
{
    class SimplePlaneControler
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        const uint KEYEVENTF_KEYUP = 0x0002;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
        private byte com_up, com_down, com_left, com_right, com_esLeft, com_esRight, com_fire;
        private GlobalVarialbles gv = GlobalVarialbles.Constructor();
        private Timer timer_cmdsBreaker = new Timer(250);

        private Queue<byte> cmds = new Queue<byte>(4);
        private byte currentKey = 0;
        private byte prevKey = 0;

        public SimplePlaneControler()
        {
            initBotCommands();
            timer_cmdsBreaker.Enabled = true;
            timer_cmdsBreaker.Elapsed += Timer_cmdsBreaker_Elapsed;
        }

        private void Timer_cmdsBreaker_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(cmds.Count > 0)
            {
                var breakCmd = cmds.Dequeue();
                keybd_event(breakCmd, 0, KEYEVENTF_KEYUP, 0);
            }
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

        private void PressKey(byte code)
        {
            keybd_event(code, 0, 0, 0);
            cmds.Enqueue(code);
        }
        public void Left()
        {
            PressKey(com_left);
        }
        public void EaseLeft()
        {
            PressKey(com_esLeft);
        }
        public void EaseRight()
        {
            PressKey(com_esRight);
        }
        public void Right()
        {
            PressKey(com_right);
        }
        public void Up()
        {
            PressKey(com_up);
        }
        public void Down()
        {
            PressKey(com_down);
        }

        public void Fire()
        {

        }
    }
}
