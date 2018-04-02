using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botiloid.Subsidiary
{
    [Serializable]
    class GlobalVarialbles
    {
        private string dataPath = @"appdata/appdata.txt";
        private static GlobalVarialbles gv;

        public Dictionary<string, Keys> botKeys;
        public Dictionary<string, int> serverCmds;
        public Dictionary<string, string> learning;

        private GlobalVarialbles()
        {
            GlobalVarialbles unpackedData;
            if (DataSerialezer.loadInfo(out unpackedData, dataPath))
            {
                botKeys = unpackedData.botKeys;
                serverCmds = unpackedData.serverCmds;
                learning = unpackedData.learning;
            }
            else
            {
                initBotKeys();
                initServerCmds();
                initLearning();
            }
        }

        ~GlobalVarialbles()
        {
            DataSerialezer.saveInfo(this, dataPath);
        }

        public static GlobalVarialbles Constructor()
        {
            if (gv == null)
                gv = new GlobalVarialbles();

            return gv;
        }

        private void initBotKeys()
        {
            botKeys = new Dictionary<string, Keys>();
            botKeys.Add("up", Keys.W);
            botKeys.Add("down", Keys.S);
            botKeys.Add("left", Keys.A);
            botKeys.Add("right", Keys.D);
            botKeys.Add("esLeft", Keys.Z);
            botKeys.Add("esRight", Keys.C);
            botKeys.Add("fire", Keys.X);
        }
        private void initServerCmds()
        {
            serverCmds = new Dictionary<string, int>();
            serverCmds.Add("up", 1);
            serverCmds.Add("down", 2);
            serverCmds.Add("right", 3);
            serverCmds.Add("left", 4);
            serverCmds.Add("esLeft", 5);
            serverCmds.Add("esRight", 6);
            serverCmds.Add("fire", 9);
            serverCmds.Add("run", 7);
            serverCmds.Add("pause", 8);
        }
        private void initLearning()
        {
            learning = new Dictionary<string, string>();
            learning.Add("times", "5");
            learning.Add("template", "{0}{1}\t{2}\t{3}\t{4}\t{5}\t{6}");
            learning.Add("path", "learning");
        }

    }
}
