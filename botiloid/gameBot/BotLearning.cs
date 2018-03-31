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

            this.bc = bc;
        }

        private void Gkl_KeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys.Remove(e.KeyCode);
        }
        private void Gkl_KeyDown(object sender, KeyEventArgs e)
        {
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
            System.Media.SystemSounds.Question.Play();
            var fs = File.Create(filePath + "/" +
                                 DateTime.Now.ToShortDateString() +
                                 "-" + DateTime.Now.Hour + "_" +
                                 DateTime.Now.Minute + extention);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Game ViewPort=[" + bc.ViewPort + "];");
            var iteration = 0;
            var cmdsBuffer = "";
            Task.Run(()=>
            {
                while(true)
                {
                    if (token.IsCancellationRequested)
                    {
                        sw.Write(cmdsBuffer);
                        sw.Close();
                        fs.Close();
                        isRecording = false;
                        break;
                    }

                    var poidata = bc.detectObj();
                    Point pt = poidata == null ? new Point(-1, -1) : poidata.pt;
                    cmdsBuffer += String.Format(template, getPressedKeys(), pt.X, pt.Y);
                    if (++iteration > 1000)
                    {
                        sw.Write(cmdsBuffer);
                        cmdsBuffer = "";
                        iteration = 0;
                    }
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
            foreach (Keys item in pressedKeys)
                res += item.ToString() + " ";

            return res;
        }
    }
}
