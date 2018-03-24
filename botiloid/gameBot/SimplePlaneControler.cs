using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace botiloid.gameBot
{
    class SimplePlaneControler
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        const uint KEYEVENTF_KEYUP = 0x0002;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        private byte currentKey = 0;
        private byte prevKey = 0;
        
        private void PressKey(byte code)
        {
            currentKey = code;
            keybd_event(prevKey, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(currentKey, 0, 0, 0);
            prevKey = currentKey;
        }
        public void Left()
        {
            PressKey(BotKeys.Left);
        }
        public void EaseLeft()
        {
            PressKey(BotKeys.EsLeft);
        }
        public void EaseRight()
        {
            PressKey(BotKeys.EsRight);
        }
        public void Right()
        {
            PressKey(BotKeys.Right);
        }
        public void Up()
        {
            PressKey(BotKeys.Up);
        }
        public void Down()
        {
            PressKey(BotKeys.Down);
        }

        public void Fire()
        {

        }


        public void release()
        {
            keybd_event(prevKey, 0, KEYEVENTF_KEYUP, 0);
        }
    }
}
