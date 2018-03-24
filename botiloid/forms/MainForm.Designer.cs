namespace botiloid
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbVisualiz = new System.Windows.Forms.PictureBox();
            this.labelCommand = new System.Windows.Forms.Label();
            this.labelDist = new System.Windows.Forms.Label();
            this.labelObjPoint = new System.Windows.Forms.Label();
            this.debugPB = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logLabel1 = new botiloid.CustomControls.LogLabel();
            this.labelLogs = new System.Windows.Forms.Label();
            this.iC_ConnectStatus = new botiloid.IndicatorControl();
            this.iC_BotStatus = new botiloid.IndicatorControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelDebug = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ботToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripStart = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripModes = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripModeDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripModeLearning = new System.Windows.Forms.ToolStripMenuItem();
            this.серверToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisualiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugPB)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iC_ConnectStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iC_BotStatus)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Статус:";
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.AutoSize = true;
            this.labelClose.Location = new System.Drawing.Point(377, 7);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(16, 20);
            this.labelClose.TabIndex = 12;
            this.labelClose.Text = "x";
            this.labelClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pbVisualiz);
            this.groupBox1.Controls.Add(this.labelCommand);
            this.groupBox1.Controls.Add(this.labelDist);
            this.groupBox1.Controls.Add(this.labelObjPoint);
            this.groupBox1.Location = new System.Drawing.Point(16, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 135);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Команда";
            // 
            // pbVisualiz
            // 
            this.pbVisualiz.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbVisualiz.Location = new System.Drawing.Point(218, 25);
            this.pbVisualiz.Name = "pbVisualiz";
            this.pbVisualiz.Size = new System.Drawing.Size(139, 90);
            this.pbVisualiz.TabIndex = 15;
            this.pbVisualiz.TabStop = false;
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(10, 77);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(14, 20);
            this.labelCommand.TabIndex = 14;
            this.labelCommand.Text = "-";
            // 
            // labelDist
            // 
            this.labelDist.AutoSize = true;
            this.labelDist.Location = new System.Drawing.Point(10, 57);
            this.labelDist.Name = "labelDist";
            this.labelDist.Size = new System.Drawing.Size(14, 20);
            this.labelDist.TabIndex = 13;
            this.labelDist.Text = "-";
            // 
            // labelObjPoint
            // 
            this.labelObjPoint.AutoSize = true;
            this.labelObjPoint.Location = new System.Drawing.Point(10, 37);
            this.labelObjPoint.Name = "labelObjPoint";
            this.labelObjPoint.Size = new System.Drawing.Size(14, 20);
            this.labelObjPoint.TabIndex = 12;
            this.labelObjPoint.Text = "-";
            // 
            // debugPB
            // 
            this.debugPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.debugPB.Location = new System.Drawing.Point(202, 21);
            this.debugPB.Name = "debugPB";
            this.debugPB.Size = new System.Drawing.Size(155, 102);
            this.debugPB.TabIndex = 11;
            this.debugPB.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(16, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Горячие клавиши";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(10, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Start / Stop";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(296, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ctrl + S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Show / Hide";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(296, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ctrl + B";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.logLabel1);
            this.panel1.Controls.Add(this.labelLogs);
            this.panel1.Controls.Add(this.iC_ConnectStatus);
            this.panel1.Controls.Add(this.iC_BotStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 42);
            this.panel1.TabIndex = 15;
            // 
            // logLabel1
            // 
            this.logLabel1.AutoEllipsis = true;
            this.logLabel1.Location = new System.Drawing.Point(140, 11);
            this.logLabel1.Name = "logLabel1";
            this.logLabel1.Size = new System.Drawing.Size(233, 20);
            this.logLabel1.TabIndex = 18;
            // 
            // labelLogs
            // 
            this.labelLogs.AutoSize = true;
            this.labelLogs.Location = new System.Drawing.Point(338, 11);
            this.labelLogs.Name = "labelLogs";
            this.labelLogs.Size = new System.Drawing.Size(0, 20);
            this.labelLogs.TabIndex = 18;
            // 
            // iC_ConnectStatus
            // 
            this.iC_ConnectStatus.BackgroundImage = global::botiloid.Properties.Resources.icr;
            this.iC_ConnectStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iC_ConnectStatus.Location = new System.Drawing.Point(114, 11);
            this.iC_ConnectStatus.MainTitle = null;
            this.iC_ConnectStatus.Name = "iC_ConnectStatus";
            this.iC_ConnectStatus.Size = new System.Drawing.Size(20, 20);
            this.iC_ConnectStatus.Status = 0;
            this.iC_ConnectStatus.TabIndex = 9;
            this.iC_ConnectStatus.TabStop = false;
            // 
            // iC_BotStatus
            // 
            this.iC_BotStatus.BackgroundImage = global::botiloid.Properties.Resources.icr;
            this.iC_BotStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iC_BotStatus.Location = new System.Drawing.Point(84, 11);
            this.iC_BotStatus.MainTitle = null;
            this.iC_BotStatus.Name = "iC_BotStatus";
            this.iC_BotStatus.Size = new System.Drawing.Size(20, 20);
            this.iC_BotStatus.Status = 0;
            this.iC_BotStatus.TabIndex = 8;
            this.iC_BotStatus.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelDebug);
            this.groupBox3.Controls.Add(this.debugPB);
            this.groupBox3.Location = new System.Drawing.Point(16, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 129);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Debug";
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDebug.Location = new System.Drawing.Point(10, 41);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(102, 37);
            this.labelDebug.TabIndex = 16;
            this.labelDebug.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ботToolStripMenuItem,
            this.серверToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(405, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ботToolStripMenuItem
            // 
            this.ботToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStart,
            this.ToolStripModes});
            this.ботToolStripMenuItem.Name = "ботToolStripMenuItem";
            this.ботToolStripMenuItem.Size = new System.Drawing.Size(52, 29);
            this.ботToolStripMenuItem.Text = "Бот";
            // 
            // ToolStripStart
            // 
            this.ToolStripStart.Name = "ToolStripStart";
            this.ToolStripStart.Size = new System.Drawing.Size(151, 30);
            this.ToolStripStart.Text = "Запуск";
            this.ToolStripStart.Click += new System.EventHandler(this.запускToolStripMenuItem_Click);
            // 
            // ToolStripModes
            // 
            this.ToolStripModes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripModeDefault,
            this.ToolStripModeLearning});
            this.ToolStripModes.Name = "ToolStripModes";
            this.ToolStripModes.Size = new System.Drawing.Size(151, 30);
            this.ToolStripModes.Text = "Режим";
            // 
            // ToolStripModeDefault
            // 
            this.ToolStripModeDefault.Checked = true;
            this.ToolStripModeDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripModeDefault.Name = "ToolStripModeDefault";
            this.ToolStripModeDefault.Size = new System.Drawing.Size(177, 30);
            this.ToolStripModeDefault.Tag = "1";
            this.ToolStripModeDefault.Text = "Обычный";
            this.ToolStripModeDefault.Click += new System.EventHandler(this.ToolStripModes_Click);
            // 
            // ToolStripModeLearning
            // 
            this.ToolStripModeLearning.Name = "ToolStripModeLearning";
            this.ToolStripModeLearning.Size = new System.Drawing.Size(177, 30);
            this.ToolStripModeLearning.Tag = "2";
            this.ToolStripModeLearning.Text = "Обучение";
            this.ToolStripModeLearning.Click += new System.EventHandler(this.ToolStripModes_Click);
            // 
            // серверToolStripMenuItem
            // 
            this.серверToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеToolStripMenuItem,
            this.информацияПодключенияToolStripMenuItem});
            this.серверToolStripMenuItem.Name = "серверToolStripMenuItem";
            this.серверToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.серверToolStripMenuItem.Text = "Сервер";
            // 
            // подключениеToolStripMenuItem
            // 
            this.подключениеToolStripMenuItem.Name = "подключениеToolStripMenuItem";
            this.подключениеToolStripMenuItem.Size = new System.Drawing.Size(322, 30);
            this.подключениеToolStripMenuItem.Text = "Подключение";
            this.подключениеToolStripMenuItem.Click += new System.EventHandler(this.подключениеToolStripMenuItem_Click);
            // 
            // информацияПодключенияToolStripMenuItem
            // 
            this.информацияПодключенияToolStripMenuItem.Name = "информацияПодключенияToolStripMenuItem";
            this.информацияПодключенияToolStripMenuItem.Size = new System.Drawing.Size(322, 30);
            this.информацияПодключенияToolStripMenuItem.Text = "Информация подключения";
            this.информацияПодключенияToolStripMenuItem.Click += new System.EventHandler(this.информацияПодключенияToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.ToolStripSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 517);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisualiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugPB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iC_ConnectStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iC_BotStatus)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox debugPB;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.Label labelDist;
        private System.Windows.Forms.Label labelObjPoint;
        private System.Windows.Forms.PictureBox pbVisualiz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ботToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripStart;
        private System.Windows.Forms.ToolStripMenuItem серверToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияПодключенияToolStripMenuItem;
        private IndicatorControl iC_ConnectStatus;
        private IndicatorControl iC_BotStatus;
        private System.Windows.Forms.ToolStripMenuItem ToolStripModes;
        private System.Windows.Forms.ToolStripMenuItem ToolStripModeDefault;
        private System.Windows.Forms.ToolStripMenuItem ToolStripModeLearning;
        private System.Windows.Forms.Label labelLogs;
        private CustomControls.LogLabel logLabel1;
    }
}

