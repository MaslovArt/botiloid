using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botiloid
{
    static class BotKeys
    {
        public static byte Up
        {
            get { return (byte)Keys.W; }
        }
        public static byte Down
        {
            get { return (byte)Keys.S; }
        }
        public static byte Left
        {
            get { return (byte)Keys.A; }
        }
        public static byte EsLeft
        {
            get { return (byte)Keys.Z; }
        }
        public static byte Right
        {
            get { return (byte)Keys.D; }
        }
        public static byte EsRight
        {
            get { return (byte)Keys.X; }
        }
    }
}
