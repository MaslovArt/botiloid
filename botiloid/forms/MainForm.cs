using botiloid.server;
using botiloid.gameBot;
using botiloid.Subsidiary;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace botiloid
{
    public partial class MainForm : Form
    {
        private GameBot gameBot;
        private string pattern = @"il2.*";
        private NetManager.NMClient nmClient;
        private SimplePlaneControler spc;
        private int com_up, com_down, com_left, com_right, com_esLeft, com_esRight, com_run, com_pause, com_fire;
        private bool wasRecoding = false;
        private Hotkey hook;

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
            gameBot.onDataReport += (e) =>
            {
                Invoke(new Action(() =>
                {
                    labelObjPoint.Text = "Obj: " + e.pt.ToString();
                    labelDist.Text = "Distance: " + e.dist.ToString();
                    labelCommand.Text = "Command: " + e.command;
                    labelfps.Text = "fps " + e.fps.ToString();
                    if (e.speed > 0)
                        labelSpeed.Text = "Speed " + e.speed + "%";
                }));
            };
        }
        private void initKeyboardHook()
        {
            hook = new Hotkey();
            hook.registerHotkey(Modifier.Ctrl, Keys.B, (e)=> 
            {
                Visible = !Visible;
            });
            var dtn = DateTime.Now;
            hook.registerHotkey(Modifier.Ctrl, Keys.S, (e) =>
            {
                if ((DateTime.Now - dtn).Seconds < 1)
                    return;
                dtn = DateTime.Now;

                if (gameBot.Status < GameBot.State.Ready)
                {
                    MessageBox.Show("Бот не инициализирован!");
                    return;
                }

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
            com_up = gv.serverCmds["up"];
            com_down = gv.serverCmds["down"];
            com_right = gv.serverCmds["right"];
            com_left = gv.serverCmds["left"];
            com_esLeft = gv.serverCmds["esLeft"];
            com_esRight = gv.serverCmds["esRight"];
            com_fire = gv.serverCmds["fire"];
            com_run = gv.serverCmds["run"];
            com_pause = gv.serverCmds["pause"];
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
            if (nmClient == null || nmClient.Running == false)
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
                        nmClient.RunClient();

                        iC_ConnectStatus.Status = 1;
                        logLabel1.Text = (iC_ConnectStatus.StateTitle);
                        initServCmds();

                        подключениеToolStripMenuItem.Text = "Отключится";
                    }
                }
            }
            else
            {
                nmClient.StopClient();
                iC_ConnectStatus.Status = 0;
                logLabel1.Text = (iC_ConnectStatus.StateTitle);
                подключениеToolStripMenuItem.Text = "Подключиться";
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

            iC_ConnectStatus.Status = 0;
            logLabel1.Text = (iC_ConnectStatus.StateTitle);
            подключениеToolStripMenuItem.Text = "Отключится";
        }
        private void NmClient_OnReseive(object sender, NetManager.EventClientMsgArgs e)
        {
            int command = BitConverter.ToInt32(e.Msg, 0);

            if (command == com_up) { }
            else if (command == com_down)
            {
                labelServCmd.Text = "Server last cmd: down";
                spc.Down();
            }
            else if (command == com_right)
            {
                labelServCmd.Text = "Server last cmd: right";
                spc.Right();
            }
            else if (command == com_left)
            {
                labelServCmd.Text = "Server last cmd: left";
                spc.Left();
            }
            else if (command == com_esLeft)
            {
                labelServCmd.Text = "Server last cmd: esLeft";
                spc.EaseRight();
            }
            else if (command == com_esRight)
            {
                labelServCmd.Text = "Server last cmd: esRight";
                spc.EaseLeft();
            }
            else if (command == com_run)
            {
                labelServCmd.Text = "Server last cmd: bot run";
                gameBot.RunAsync();
            }
            else if (command == com_pause)
            {
                labelServCmd.Text = "Server last cmd: bot pause";
                gameBot.Stop();
            }
            else if (command == com_fire)
            {
                spc.Fire();
            }
        }

        #region Form moving
        private bool dragging = false;
        private Point StartPoint = new Point(0, 0);
        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            this.Cursor = Cursors.NoMove2D;
            StartPoint = new Point(e.X, e.Y);
        }
        private void panelUp_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            this.Cursor = Cursors.Default;
        }
        private void panelUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - StartPoint.X, p.Y - StartPoint.Y);
            }
        }
        #endregion
    }
}
