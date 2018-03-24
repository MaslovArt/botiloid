using botiloid.server;
using botiloid.gameBot;
using botiloid.Subsidiary;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace botiloid
{
    public partial class MainForm : Form
    {
        private GameBot gameBot;
        private Hotkey hook;
        private string pattern = @"il2.*";
        private NetManager.NMClient nmClient;
        private SimplePlaneControler spc;
        private int com_up, com_down, com_left, com_right, com_esLeft, com_esRight, com_run, com_pause, com_fire;
        private bool isVisible = true, wasRecoding = false;


        public MainForm()
        {
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - Width,
                                      Screen.PrimaryScreen.Bounds.Bottom - Height);

            iC_BotStatus.setStatusImgs(Properties.Resources.icr,
                                       Properties.Resources.ico,
                                       Properties.Resources.icg,
                                       Properties.Resources.icdg);
            iC_BotStatus.setStatusTitles("Выключен", "Поиск приложения", "Готов", "Активный");
            iC_BotStatus.MainTitle = "Бот";
            iC_ConnectStatus.setStatusImgs(Properties.Resources.icr,
                                           Properties.Resources.icdg);
            iC_ConnectStatus.setStatusTitles("Нет подключения", "Подключено");
            iC_ConnectStatus.MainTitle = "Сервер";

            initKeyboardHook();
            initBot();

        }

        private void initBot()
        {

            gameBot = new GameBot();
            gameBot.onStateChange += (e) =>
            {
                iC_BotStatus.Invoke(new Action(() =>
                {
                    iC_BotStatus.Status = (int)e;

                    if (gameBot.BMode == GameBot.Mode.Default)
                    {
                        logLabel1.Text = iC_BotStatus.StateTitle;
                    }
                    else
                    {
                        if (gameBot.Status == GameBot.State.Active)
                        {
                            logLabel1.Text = "Начало записи";
                            wasRecoding = true;
                        }
                        if (gameBot.Status == GameBot.State.Ready && wasRecoding)
                        {
                            logLabel1.Text = "Остановка записи и сохранение";
                            wasRecoding = false;
                        }
                    }
                }));
            };
            gameBot.onCommandReport += (e) =>
            {
                labelObjPoint.Invoke(new Action(() =>
                {
                    labelObjPoint.Text = "Obj: " + e.pt.ToString();
                    labelDist.Text = "Distance: " + e.midDist.ToString();
                    labelDebug.Text = e.dist;
                    labelCommand.Text = "Command: " + e.command;
                }));
            };

            gameBot.botDebug += (e) =>
            {
                debugPB.Invoke(new Action(() =>
                {
                    debugPB.BackgroundImage = e as Bitmap;
                }));
            };
        }
        private void initKeyboardHook()
        {
            hook = new Hotkey();
            hook.registerHotkey(Modifier.Ctrl, Keys.B, (e)=> 
            {
                if (isVisible)
                    Left += Width;
                else
                    Left -= Width;
                isVisible = !isVisible;
            });
            var dtn = DateTime.Now;
            hook.registerHotkey(Modifier.Ctrl, Keys.S, (e) =>
            {
                if ((DateTime.Now - dtn).Seconds < 1)
                    return;
                dtn = DateTime.Now;

                if (gameBot.Status < GameBot.State.Ready)
                    return;

                if (gameBot.Status == GameBot.State.Active)
                {
                    gameBot.Stop();
                }
                else {
                    gameBot.RunAsync();
                }
            });
        }
        private void initServCmds()
        {
            spc = new SimplePlaneControler();
            GlobalVarialbles gv = GlobalVarialbles.Constructor();
            com_up = Convert.ToInt32(gv.serverCmds["up"]);
            com_down = Convert.ToInt32(gv.serverCmds["down"]);
            com_right = Convert.ToInt32(gv.serverCmds["right"]);
            com_left = Convert.ToInt32(gv.serverCmds["left"]);
            com_esLeft = Convert.ToInt32(gv.serverCmds["esLeft"]);
            com_esRight = Convert.ToInt32(gv.serverCmds["esRight"]);
            com_fire = Convert.ToInt32(gv.serverCmds["fire"]);
            com_run = Convert.ToInt32(gv.serverCmds["run"]);
            com_pause = Convert.ToInt32(gv.serverCmds["pause"]);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void запускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameBot.initBotAsync(pattern);
        }
        private void подключениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Connect dialog = new Connect())
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    nmClient = new NetManager.NMClient(this);
                    nmClient.OnReseive += NmClient_OnReseive;
                    nmClient.OnError += NmClient_OnError;
                    nmClient.IPServer = IPAddress.Parse(dialog.HostName);
                    nmClient.Port = dialog.Port;
                    nmClient.Name = dialog.UserName;
                    try
                    {
                        nmClient.RunClient();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка при подключении: {0}", ex.Message);
                    }
                    iC_ConnectStatus.Status = 2;
                    logLabel1.Text = (iC_ConnectStatus.StateTitle);
                    initServCmds();
                }
            }
        }
        private void информацияПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nmClient == null)
                MessageBox.Show("Подключение к серверу отсутствует");
            else
                MessageBox.Show(String.Format("IP server: {0}\nPort: {1}\nUserName: {2}",
                                              nmClient.IPServer,
                                              nmClient.Port,
                                              nmClient.Name));
        }
        private void ToolStripSettings_Click(object sender, EventArgs e)
        {
            var sets = new Settings();
            sets.ShowDialog();
        }
        private void ToolStripModes_Click(object sender, EventArgs e)
        {
            ToolStripModeDefault.Checked = false;
            ToolStripModeLearning.Checked = false;
            var tsmi = sender as ToolStripMenuItem;
            tsmi.Checked = true;
            logLabel1.Text = ("Режим: " + tsmi.Text);
            if ((string)tsmi.Tag == "1")
                gameBot.BMode = GameBot.Mode.Default;
            else
                gameBot.BMode = GameBot.Mode.Learning;
        }

        private void NmClient_OnError(object sender, NetManager.EventMsgArgs e)
        {
            MessageBox.Show("Ошибка сервера: " + e.Msg);
        }
        private void NmClient_OnReseive(object sender, NetManager.EventClientMsgArgs e)
        {
            int command = BitConverter.ToInt32(e.Msg, 0);
            if (command == com_up) { }
            else if (command == com_down) { spc.Down(); }
            else if (command == com_right) { spc.Right(); }
            else if (command == com_left) { spc.Left(); }
            else if (command == com_esLeft) { spc.EaseRight(); }
            else if (command == com_esRight) { spc.EaseLeft(); }
            else if (command == com_run) { gameBot.RunAsync(); }
            else if (command == com_pause) { gameBot.Stop(); }
            else if (command == com_fire) { spc.Fire(); }
        }
    }
}
