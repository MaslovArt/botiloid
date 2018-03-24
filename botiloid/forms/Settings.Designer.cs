namespace botiloid
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Server = new System.Windows.Forms.TabPage();
            this.gbServСontrol2 = new System.Windows.Forms.GroupBox();
            this.tbServBotPause = new System.Windows.Forms.TextBox();
            this.tbServBotActivate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbServСontrol1 = new System.Windows.Forms.GroupBox();
            this.tbFire = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbServEsRight = new System.Windows.Forms.TextBox();
            this.tbServEsLeft = new System.Windows.Forms.TextBox();
            this.tbServRight = new System.Windows.Forms.TextBox();
            this.tbServLeft = new System.Windows.Forms.TextBox();
            this.tbServDown = new System.Windows.Forms.TextBox();
            this.tbServUp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Game = new System.Windows.Forms.TabPage();
            this.gbGameСontrol1 = new System.Windows.Forms.GroupBox();
            this.tbGameEsRight = new System.Windows.Forms.TextBox();
            this.tbGameEsLeft = new System.Windows.Forms.TextBox();
            this.tbGameRight = new System.Windows.Forms.TextBox();
            this.tbGameLeft = new System.Windows.Forms.TextBox();
            this.tbGameDown = new System.Windows.Forms.TextBox();
            this.tbGameUp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Learning = new System.Windows.Forms.TabPage();
            this.labelPath = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.template = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.udTimes = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Server.SuspendLayout();
            this.gbServСontrol2.SuspendLayout();
            this.gbServСontrol1.SuspendLayout();
            this.Game.SuspendLayout();
            this.gbGameСontrol1.SuspendLayout();
            this.Learning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.Server);
            this.tabControl.Controls.Add(this.Game);
            this.tabControl.Controls.Add(this.Learning);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(393, 425);
            this.tabControl.TabIndex = 0;
            // 
            // Server
            // 
            this.Server.Controls.Add(this.gbServСontrol2);
            this.Server.Controls.Add(this.gbServСontrol1);
            this.Server.Location = new System.Drawing.Point(4, 29);
            this.Server.Name = "Server";
            this.Server.Padding = new System.Windows.Forms.Padding(3);
            this.Server.Size = new System.Drawing.Size(385, 392);
            this.Server.TabIndex = 0;
            this.Server.Text = "Сервер";
            this.Server.UseVisualStyleBackColor = true;
            // 
            // gbServСontrol2
            // 
            this.gbServСontrol2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbServСontrol2.Controls.Add(this.tbServBotPause);
            this.gbServСontrol2.Controls.Add(this.tbServBotActivate);
            this.gbServСontrol2.Controls.Add(this.label7);
            this.gbServСontrol2.Controls.Add(this.label8);
            this.gbServСontrol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbServСontrol2.Location = new System.Drawing.Point(6, 278);
            this.gbServСontrol2.Name = "gbServСontrol2";
            this.gbServСontrol2.Size = new System.Drawing.Size(373, 105);
            this.gbServСontrol2.TabIndex = 7;
            this.gbServСontrol2.TabStop = false;
            this.gbServСontrol2.Text = "Управление ботом";
            // 
            // tbServBotPause
            // 
            this.tbServBotPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServBotPause.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbServBotPause.Location = new System.Drawing.Point(256, 66);
            this.tbServBotPause.Name = "tbServBotPause";
            this.tbServBotPause.Size = new System.Drawing.Size(100, 26);
            this.tbServBotPause.TabIndex = 9;
            this.tbServBotPause.Tag = "pause";
            this.tbServBotPause.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbServBotPause.TextChanged += new System.EventHandler(this.tbServ_TextChanged);
            // 
            // tbServBotActivate
            // 
            this.tbServBotActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServBotActivate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbServBotActivate.Location = new System.Drawing.Point(256, 32);
            this.tbServBotActivate.Name = "tbServBotActivate";
            this.tbServBotActivate.Size = new System.Drawing.Size(100, 26);
            this.tbServBotActivate.TabIndex = 8;
            this.tbServBotActivate.Tag = "run";
            this.tbServBotActivate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbServBotActivate.TextChanged += new System.EventHandler(this.tbServ_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Активировать:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Приостановить:";
            // 
            // gbServСontrol1
            // 
            this.gbServСontrol1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbServСontrol1.Controls.Add(this.tbFire);
            this.gbServСontrol1.Controls.Add(this.label9);
            this.gbServСontrol1.Controls.Add(this.tbServEsRight);
            this.gbServСontrol1.Controls.Add(this.tbServEsLeft);
            this.gbServСontrol1.Controls.Add(this.tbServRight);
            this.gbServСontrol1.Controls.Add(this.tbServLeft);
            this.gbServСontrol1.Controls.Add(this.tbServDown);
            this.gbServСontrol1.Controls.Add(this.tbServUp);
            this.gbServСontrol1.Controls.Add(this.label1);
            this.gbServСontrol1.Controls.Add(this.label6);
            this.gbServСontrol1.Controls.Add(this.label2);
            this.gbServСontrol1.Controls.Add(this.label5);
            this.gbServСontrol1.Controls.Add(this.label3);
            this.gbServСontrol1.Controls.Add(this.label4);
            this.gbServСontrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbServСontrol1.Location = new System.Drawing.Point(6, 6);
            this.gbServСontrol1.Name = "gbServСontrol1";
            this.gbServСontrol1.Size = new System.Drawing.Size(373, 266);
            this.gbServСontrol1.TabIndex = 6;
            this.gbServСontrol1.TabStop = false;
            this.gbServСontrol1.Text = "Управдение самолетом";
            // 
            // tbFire
            // 
            this.tbFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFire.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbFire.Location = new System.Drawing.Point(256, 233);
            this.tbFire.Name = "tbFire";
            this.tbFire.Size = new System.Drawing.Size(100, 26);
            this.tbFire.TabIndex = 13;
            this.tbFire.Tag = "fire";
            this.tbFire.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbFire.TextChanged += new System.EventHandler(this.tbServ_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(16, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Огонь:";
            // 
            // tbServEsRight
            // 
            this.tbServEsRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServEsRight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbServEsRight.Location = new System.Drawing.Point(256, 199);
            this.tbServEsRight.Name = "tbServEsRight";
            this.tbServEsRight.Size = new System.Drawing.Size(100, 26);
            this.tbServEsRight.TabIndex = 11;
            this.tbServEsRight.Tag = "esRight";
            this.tbServEsRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbServEsRight.TextChanged += new System.EventHandler(this.tbServ_TextChanged);
            // 
            // tbServEsLeft
            // 
            this.tbServEsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServEsLeft.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbServEsLeft.Location = new System.Drawing.Point(256, 165);
            this.tbServEsLeft.Name = "tbServEsLeft";
            this.tbServEsLeft.Size = new System.Drawing.Size(100, 26);
            this.tbServEsLeft.TabIndex = 10;
            this.tbServEsLeft.Tag = "esLeft";
            this.tbServEsLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbServEsLeft.TextChanged += new System.EventHandler(this.tbServ_TextChanged);
            // 
            // tbServRight
            // 
            this.tbServRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServRight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbServRight.Location = new System.Drawing.Point(256, 131);
            this.tbServRight.Name = "tbServRight";
            this.tbServRight.Size = new System.Drawing.Size(100, 26);
            this.tbServRight.TabIndex = 9;
            this.tbServRight.Tag = "right";
            this.tbServRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbServRight.TextChanged += new System.EventHandler(this.tbServ_TextChanged);
            // 
            // tbServLeft
            // 
            this.tbServLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServLeft.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbServLeft.Location = new System.Drawing.Point(256, 99);
            this.tbServLeft.Name = "tbServLeft";
            this.tbServLeft.Size = new System.Drawing.Size(100, 26);
            this.tbServLeft.TabIndex = 8;
            this.tbServLeft.Tag = "left";
            this.tbServLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbServLeft.TextChanged += new System.EventHandler(this.tbServ_TextChanged);
            // 
            // tbServDown
            // 
            this.tbServDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServDown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbServDown.Location = new System.Drawing.Point(256, 65);
            this.tbServDown.Name = "tbServDown";
            this.tbServDown.Size = new System.Drawing.Size(100, 26);
            this.tbServDown.TabIndex = 7;
            this.tbServDown.Tag = "down";
            this.tbServDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbServDown.TextChanged += new System.EventHandler(this.tbServ_TextChanged);
            // 
            // tbServUp
            // 
            this.tbServUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServUp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbServUp.Location = new System.Drawing.Point(256, 31);
            this.tbServUp.Name = "tbServUp";
            this.tbServUp.Size = new System.Drawing.Size(100, 26);
            this.tbServUp.TabIndex = 6;
            this.tbServUp.Tag = "up";
            this.tbServUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbServUp.TextChanged += new System.EventHandler(this.tbServ_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вверх:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Вправо-хвост:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вниз:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Влево-хвост:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вправо:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Влево:";
            // 
            // Game
            // 
            this.Game.Controls.Add(this.gbGameСontrol1);
            this.Game.Location = new System.Drawing.Point(4, 29);
            this.Game.Name = "Game";
            this.Game.Padding = new System.Windows.Forms.Padding(3);
            this.Game.Size = new System.Drawing.Size(385, 392);
            this.Game.TabIndex = 1;
            this.Game.Text = "Бот";
            this.Game.UseVisualStyleBackColor = true;
            // 
            // gbGameСontrol1
            // 
            this.gbGameСontrol1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGameСontrol1.Controls.Add(this.tbGameEsRight);
            this.gbGameСontrol1.Controls.Add(this.tbGameEsLeft);
            this.gbGameСontrol1.Controls.Add(this.tbGameRight);
            this.gbGameСontrol1.Controls.Add(this.tbGameLeft);
            this.gbGameСontrol1.Controls.Add(this.tbGameDown);
            this.gbGameСontrol1.Controls.Add(this.tbGameUp);
            this.gbGameСontrol1.Controls.Add(this.label11);
            this.gbGameСontrol1.Controls.Add(this.label12);
            this.gbGameСontrol1.Controls.Add(this.label13);
            this.gbGameСontrol1.Controls.Add(this.label14);
            this.gbGameСontrol1.Controls.Add(this.label15);
            this.gbGameСontrol1.Controls.Add(this.label16);
            this.gbGameСontrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbGameСontrol1.Location = new System.Drawing.Point(6, 6);
            this.gbGameСontrol1.Name = "gbGameСontrol1";
            this.gbGameСontrol1.Size = new System.Drawing.Size(373, 238);
            this.gbGameСontrol1.TabIndex = 7;
            this.gbGameСontrol1.TabStop = false;
            this.gbGameСontrol1.Text = "Управдение самолетом в игре";
            // 
            // tbGameEsRight
            // 
            this.tbGameEsRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGameEsRight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbGameEsRight.Location = new System.Drawing.Point(256, 199);
            this.tbGameEsRight.MaxLength = 1;
            this.tbGameEsRight.Name = "tbGameEsRight";
            this.tbGameEsRight.Size = new System.Drawing.Size(100, 26);
            this.tbGameEsRight.TabIndex = 11;
            this.tbGameEsRight.Tag = "esRight";
            this.tbGameEsRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGameEsRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbGame_KeyDown);
            // 
            // tbGameEsLeft
            // 
            this.tbGameEsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGameEsLeft.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbGameEsLeft.Location = new System.Drawing.Point(256, 165);
            this.tbGameEsLeft.MaxLength = 1;
            this.tbGameEsLeft.Name = "tbGameEsLeft";
            this.tbGameEsLeft.Size = new System.Drawing.Size(100, 26);
            this.tbGameEsLeft.TabIndex = 10;
            this.tbGameEsLeft.Tag = "esLeft";
            this.tbGameEsLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGameEsLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbGame_KeyDown);
            // 
            // tbGameRight
            // 
            this.tbGameRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGameRight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbGameRight.Location = new System.Drawing.Point(256, 131);
            this.tbGameRight.MaxLength = 1;
            this.tbGameRight.Name = "tbGameRight";
            this.tbGameRight.Size = new System.Drawing.Size(100, 26);
            this.tbGameRight.TabIndex = 9;
            this.tbGameRight.Tag = "right";
            this.tbGameRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGameRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbGame_KeyDown);
            // 
            // tbGameLeft
            // 
            this.tbGameLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGameLeft.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbGameLeft.Location = new System.Drawing.Point(256, 99);
            this.tbGameLeft.MaxLength = 1;
            this.tbGameLeft.Name = "tbGameLeft";
            this.tbGameLeft.Size = new System.Drawing.Size(100, 26);
            this.tbGameLeft.TabIndex = 8;
            this.tbGameLeft.Tag = "left";
            this.tbGameLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGameLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbGame_KeyDown);
            // 
            // tbGameDown
            // 
            this.tbGameDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGameDown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbGameDown.Location = new System.Drawing.Point(256, 65);
            this.tbGameDown.MaxLength = 1;
            this.tbGameDown.Name = "tbGameDown";
            this.tbGameDown.Size = new System.Drawing.Size(100, 26);
            this.tbGameDown.TabIndex = 7;
            this.tbGameDown.Tag = "down";
            this.tbGameDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGameDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbGame_KeyDown);
            // 
            // tbGameUp
            // 
            this.tbGameUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGameUp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbGameUp.Location = new System.Drawing.Point(256, 31);
            this.tbGameUp.MaxLength = 1;
            this.tbGameUp.Name = "tbGameUp";
            this.tbGameUp.Size = new System.Drawing.Size(100, 26);
            this.tbGameUp.TabIndex = 6;
            this.tbGameUp.Tag = "up";
            this.tbGameUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGameUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbGame_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(16, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Вверх:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(16, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Вправо-хвост:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(16, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Вниз:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(16, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Влево-хвост:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(16, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Вправо:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(16, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Влево:";
            // 
            // Learning
            // 
            this.Learning.Controls.Add(this.label19);
            this.Learning.Controls.Add(this.udTimes);
            this.Learning.Controls.Add(this.label18);
            this.Learning.Controls.Add(this.label17);
            this.Learning.Controls.Add(this.template);
            this.Learning.Controls.Add(this.labelPath);
            this.Learning.Controls.Add(this.label10);
            this.Learning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Learning.Location = new System.Drawing.Point(4, 29);
            this.Learning.Name = "Learning";
            this.Learning.Size = new System.Drawing.Size(385, 392);
            this.Learning.TabIndex = 2;
            this.Learning.Text = "Обучение";
            this.Learning.UseVisualStyleBackColor = true;
            // 
            // labelPath
            // 
            this.labelPath.AutoEllipsis = true;
            this.labelPath.AutoSize = true;
            this.labelPath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelPath.Location = new System.Drawing.Point(80, 120);
            this.labelPath.MaximumSize = new System.Drawing.Size(280, 20);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(60, 20);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "label17";
            this.labelPath.TextChanged += new System.EventHandler(this.labelPath_TextChanged);
            this.labelPath.Click += new System.EventHandler(this.labelPath_click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Путь: ";
            // 
            // template
            // 
            this.template.Location = new System.Drawing.Point(258, 57);
            this.template.Name = "template";
            this.template.Size = new System.Drawing.Size(100, 26);
            this.template.TabIndex = 3;
            this.template.TextChanged += new System.EventHandler(this.template_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 20);
            this.label17.TabIndex = 4;
            this.label17.Text = "Шаблон:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 20);
            this.label18.TabIndex = 5;
            this.label18.Text = "Захват (в секунду):";
            // 
            // udTimes
            // 
            this.udTimes.Location = new System.Drawing.Point(258, 19);
            this.udTimes.Name = "udTimes";
            this.udTimes.Size = new System.Drawing.Size(100, 26);
            this.udTimes.TabIndex = 6;
            this.udTimes.ValueChanged += new System.EventHandler(this.udTimes_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Location = new System.Drawing.Point(20, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(210, 20);
            this.label19.TabIndex = 7;
            this.label19.Text = "{0} - клавиши, {1} - X, {2} - Y";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 444);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Settings_KeyPress);
            this.tabControl.ResumeLayout(false);
            this.Server.ResumeLayout(false);
            this.gbServСontrol2.ResumeLayout(false);
            this.gbServСontrol2.PerformLayout();
            this.gbServСontrol1.ResumeLayout(false);
            this.gbServСontrol1.PerformLayout();
            this.Game.ResumeLayout(false);
            this.gbGameСontrol1.ResumeLayout(false);
            this.gbGameСontrol1.PerformLayout();
            this.Learning.ResumeLayout(false);
            this.Learning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udTimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Server;
        private System.Windows.Forms.GroupBox gbServСontrol1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage Game;
        private System.Windows.Forms.GroupBox gbServСontrol2;
        private System.Windows.Forms.TextBox tbServBotPause;
        private System.Windows.Forms.TextBox tbServBotActivate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFire;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbServEsRight;
        private System.Windows.Forms.TextBox tbServEsLeft;
        private System.Windows.Forms.TextBox tbServRight;
        private System.Windows.Forms.TextBox tbServLeft;
        private System.Windows.Forms.TextBox tbServDown;
        private System.Windows.Forms.TextBox tbServUp;
        private System.Windows.Forms.GroupBox gbGameСontrol1;
        private System.Windows.Forms.TextBox tbGameEsRight;
        private System.Windows.Forms.TextBox tbGameEsLeft;
        private System.Windows.Forms.TextBox tbGameRight;
        private System.Windows.Forms.TextBox tbGameLeft;
        private System.Windows.Forms.TextBox tbGameDown;
        private System.Windows.Forms.TextBox tbGameUp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage Learning;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown udTimes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox template;
        private System.Windows.Forms.Label label19;
    }
}