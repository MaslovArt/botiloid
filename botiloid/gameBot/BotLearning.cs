using botiloid.Subsidiary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botiloid.gameBot
{
    class BotLearning
    {
        private globalKeyboardHook gkl = new globalKeyboardHook();
        private List<Keys> pressedKeys;
        private BotCV bc;
        private bool isRecording = false;

        private string filePath;
        private int delay;
        private string template;
        private string extention = ".txt";

        private byte com_up, com_down, com_left, com_right, com_esLeft, com_esRight, com_fire, com_flaps_next, com_flaps_prev;
        private string speed = "D0";
        private int flaps = 1;
        private int dist = -1;
        private bool isFire = false;

        public bool IsRecoding
        {
            get { return isRecording; }
        }

        public BotLearning(BotCV bc)
        {
            pressedKeys = new List<Keys>(4);
            gkl.KeyDown += Gkl_KeyDown;
            gkl.KeyUp += Gkl_KeyUp;

            GlobalVarialbles gv = GlobalVarialbles.Constructor();
            delay = 1000 / Convert.ToInt32(gv.learning["times"]);
            template = gv.learning["template"];
            filePath = gv.learning["path"];
            com_fire = (byte)gv.botKeys["fire"];

            com_down = (byte)gv.botKeys["down"];
            com_up = (byte)gv.botKeys["up"];
            com_left = (byte)gv.botKeys["left"];
            com_right = (byte)gv.botKeys["right"];
            com_esRight = (byte)gv.botKeys["esRight"];
            com_esLeft = (byte)gv.botKeys["esLeft"];
            com_flaps_next = (byte)gv.botKeys["flaps-next"];
            com_flaps_prev = (byte)gv.botKeys["flaps-prev"];

            this.bc = bc;
        }

        private void Gkl_KeyUp(object sender, KeyEventArgs e)
        {
            if ((byte)e.KeyCode == com_fire)
            {
                isFire = false;
                return;
            }
            pressedKeys.Remove(e.KeyCode);
        }
        private void Gkl_KeyDown(object sender, KeyEventArgs e)
        {
            if((int)e.KeyCode == com_flaps_next)
            {
                if (flaps < 4)
                    flaps++;
                return;
            }
            if ((int)e.KeyCode == com_flaps_prev)
            {
                if (flaps > 1)
                    flaps--;
                return;
            }
            if ((int)e.KeyCode < 58)
            {
                speed = e.KeyCode.ToString();
                return;
            }
            if ((byte)e.KeyCode == com_fire)
            {
                isFire = true;
                return;
            }
            
            if (!pressedKeys.Contains(e.KeyCode))
            {
                pressedKeys.Add(e.KeyCode);
            }
        }

        /// <summary>
        /// Запускает запись команд
        /// </summary>
        /// <param name="token">Источник признака отмены</param>
        public void StartRecordAsync(CancellationToken token)
        {
            if (isRecording)
                return;

            isRecording = true;
            var fs = File.Create(filePath + "/" +
                                 DateTime.Now.ToShortDateString() +
                                 "-" + DateTime.Now.Hour + "_" +
                                 DateTime.Now.Minute + "_" +
                                 DateTime.Now.Second +
                                 extention);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Game ViewPort=[" + bc.ViewPort + "];");
            sw.WriteLine("Up Down Left Right EsLeft EsRight Speed Flaps Fire Coor.X Coor.Y Distance");
            var cmdsBuffer = "";
            Task.Run(()=>
            {
                while(true)
                {
                    if (token.IsCancellationRequested)
                    {
                        sw.Close();
                        fs.Close();
                        isRecording = false;
                        break;
                    }

                    var poidata = bc.detectObj();
                    Point pt = poidata == null ? new Point(-1, -1) : poidata.pt;
                    dist = poidata.dist;
                    cmdsBuffer = String.Format(template, getPressedKeys(),
                                                          speed[1],
                                                          flaps,
                                                          isFire ? "1" : "0",
                                                          pt.X, pt.Y,
                                                          dist);
                    sw.WriteLine(cmdsBuffer);
                    Thread.Sleep(delay);
                }
                isRecording = false;
            }, token);
        }
        
        /// <summary>
        /// Получает список зажатых клавишь
        /// </summary>
        /// <returns>Строка с символами клавишь</returns>
        private string getPressedKeys()
        {
            var res = "";

            res += pressedKeys.Contains((Keys)com_up) ? "1\t" : "0\t";
            res += pressedKeys.Contains((Keys)com_down) ? "1\t" : "0\t";
            res += pressedKeys.Contains((Keys)com_left) ? "1\t" : "0\t";
            res += pressedKeys.Contains((Keys)com_right) ? "1\t" : "0\t";
            res += pressedKeys.Contains((Keys)com_esLeft) ? "1\t" : "0\t";
            res += pressedKeys.Contains((Keys)com_esRight) ? "1\t" : "0\t";

            return res;
        }
    }
}
