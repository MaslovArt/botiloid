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
            this.labelClose = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelServCmd = new System.Windows.Forms.Label();
            this.labelfps = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelCommand = new System.Windows.Forms.Label();
            this.labelDist = new System.Windows.Forms.Label();
            this.labelObjPoint = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.logLabel1 = new botiloid.CustomControls.LogLabel();
            this.iC_ConnectStatus = new botiloid.IndicatorControl();
            this.iC_BotStatus = new botiloid.IndicatorControl();
            this.начатьПриемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iC_ConnectStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iC_BotStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Location = new System.Drawing.Point(290, 7);
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
            this.groupBox1.Controls.Add(this.labelServCmd);
            this.groupBox1.Controls.Add(this.labelfps);
            this.groupBox1.Controls.Add(this.labelSpeed);
            this.groupBox1.Controls.Add(this.labelCommand);
            this.groupBox1.Controls.Add(this.labelDist);
            this.groupBox1.Controls.Add(this.labelObjPoint);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(16, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 153);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные бота";
            // 
            // labelServCmd
            // 
            this.labelServCmd.AutoSize = true;
            this.labelServCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelServCmd.Location = new System.Drawing.Point(10, 117);
            this.labelServCmd.Name = "labelServCmd";
            this.labelServCmd.Size = new System.Drawing.Size(14, 20);
            this.labelServCmd.TabIndex = 17;
            this.labelServCmd.Text = "-";
            // 
            // labelfps
            // 
            this.labelfps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelfps.AutoSize = true;
            this.labelfps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfps.Location = new System.Drawing.Point(209, 37);
            this.labelfps.Name = "labelfps";
            this.labelfps.Size = new System.Drawing.Size(31, 20);
            this.labelfps.TabIndex = 18;
            this.labelfps.Text = "fps";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.Location = new System.Drawing.Point(10, 97);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(14, 20);
            this.labelSpeed.TabIndex = 16;
            this.labelSpeed.Text = "-";
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCommand.Location = new System.Drawing.Point(10, 77);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(14, 20);
            this.labelCommand.TabIndex = 14;
            this.labelCommand.Text = "-";
            // 
            // labelDist
            // 
            this.labelDist.AutoSize = true;
            this.labelDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDist.Location = new System.Drawing.Point(10, 57);
            this.labelDist.Name = "labelDist";
            this.labelDist.Size = new System.Drawing.Size(14, 20);
            this.labelDist.TabIndex = 13;
            this.labelDist.Text = "-";
            // 
            // labelObjPoint
            // 
            this.labelObjPoint.AutoSize = true;
            this.labelObjPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObjPoint.Location = new System.Drawing.Point(10, 37);
            this.labelObjPoint.Name = "labelObjPoint";
            this.labelObjPoint.Size = new System.Drawing.Size(14, 20);
            this.labelObjPoint.TabIndex = 12;
            this.labelObjPoint.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(16, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 77);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Горячие клавиши";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(10, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Старт / Стоп";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(209, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ctrl + S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Показать / Спрятать";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(209, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ctrl + B";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ботToolStripMenuItem,
            this.серверToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 32);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ботToolStripMenuItem
            // 
            this.ботToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStart,
            this.ToolStripModes});
            this.ботToolStripMenuItem.Name = "ботToolStripMenuItem";
            this.ботToolStripMenuItem.Size = new System.Drawing.Size(50, 28);
            this.ботToolStripMenuItem.Text = "Бот";
            // 
            // ToolStripStart
            // 
            this.ToolStripStart.Name = "ToolStripStart";
            this.ToolStripStart.Size = new System.Drawing.Size(142, 30);
            this.ToolStripStart.Text = "Запуск";
            this.ToolStripStart.Click += new System.EventHandler(this.запускToolStripMenuItem_Click);
            // 
            // ToolStripModes
            // 
            this.ToolStripModes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripModeDefault,
            this.ToolStripModeLearning});
            this.ToolStripModes.Name = "ToolStripModes";
            this.ToolStripModes.Size = new System.Drawing.Size(142, 30);
            this.ToolStripModes.Text = "Режим";
            // 
            // ToolStripModeDefault
            // 
            this.ToolStripModeDefault.Checked = true;
            this.ToolStripModeDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripModeDefault.Name = "ToolStripModeDefault";
            this.ToolStripModeDefault.Size = new System.Drawing.Size(163, 30);
            this.ToolStripModeDefault.Tag = "1";
            this.ToolStripModeDefault.Text = "Обычный";
            this.ToolStripModeDefault.Click += new System.EventHandler(this.ToolStripModes_Click);
            // 
            // ToolStripModeLearning
            // 
            this.ToolStripModeLearning.Name = "ToolStripModeLearning";
            this.ToolStripModeLearning.Size = new System.Drawing.Size(163, 30);
            this.ToolStripModeLearning.Tag = "2";
            this.ToolStripModeLearning.Text = "Обучение";
            this.ToolStripModeLearning.Click += new System.EventHandler(this.ToolStripModes_Click);
            // 
            // серверToolStripMenuItem
            // 
            this.серверToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеToolStripMenuItem,
            this.информацияПодключенияToolStripMenuItem,
            this.начатьПриемToolStripMenuItem});
            this.серверToolStripMenuItem.Name = "серверToolStripMenuItem";
            this.серверToolStripMenuItem.Size = new System.Drawing.Size(77, 28);
            this.серверToolStripMenuItem.Text = "Сервер";
            // 
            // подключениеToolStripMenuItem
            // 
            this.подключениеToolStripMenuItem.Name = "подключениеToolStripMenuItem";
            this.подключениеToolStripMenuItem.Size = new System.Drawing.Size(298, 30);
            this.подключениеToolStripMenuItem.Text = "Подключение";
            this.подключениеToolStripMenuItem.Click += new System.EventHandler(this.подключениеToolStripMenuItem_Click);
            // 
            // информацияПодключенияToolStripMenuItem
            // 
            this.информацияПодключенияToolStripMenuItem.Name = "информацияПодключенияToolStripMenuItem";
            this.информацияПодключенияToolStripMenuItem.Size = new System.Drawing.Size(298, 30);
            this.информацияПодключенияToolStripMenuItem.Text = "Информация подключения";
            this.информацияПодключенияToolStripMenuItem.Click += new System.EventHandler(this.информацияПодключенияToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.ToolStripSettings_Click);
            // 
            // logLabel1
            // 
            this.logLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logLabel1.AutoEllipsis = true;
            this.logLabel1.Location = new System.Drawing.Point(76, 44);
            this.logLabel1.Name = "logLabel1";
            this.logLabel1.Size = new System.Drawing.Size(226, 20);
            this.logLabel1.TabIndex = 18;
            // 
            // iC_ConnectStatus
            // 
            this.iC_ConnectStatus.BackgroundImage = global::botiloid.Properties.Resources.icr;
            this.iC_ConnectStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iC_ConnectStatus.Location = new System.Drawing.Point(50, 44);
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
            this.iC_BotStatus.Location = new System.Drawing.Point(20, 44);
            this.iC_BotStatus.MainTitle = null;
            this.iC_BotStatus.Name = "iC_BotStatus";
            this.iC_BotStatus.Size = new System.Drawing.Size(20, 20);
            this.iC_BotStatus.Status = 0;
            this.iC_BotStatus.TabIndex = 8;
            this.iC_BotStatus.TabStop = false;
            // 
            // начатьПриемToolStripMenuItem
            // 
            this.начатьПриемToolStripMenuItem.Name = "начатьПриемToolStripMenuItem";
            this.начатьПриемToolStripMenuItem.Size = new System.Drawing.Size(298, 30);
            this.начатьПриемToolStripMenuItem.Text = "Начать прием";
            this.начатьПриемToolStripMenuItem.Click += new System.EventHandler(this.начатьПриемToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 336);
            this.Controls.Add(this.logLabel1);
            this.Controls.Add(this.iC_ConnectStatus);
            this.Controls.Add(this.iC_BotStatus);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iC_ConnectStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iC_BotStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.Label labelDist;
        private System.Windows.Forms.Label labelObjPoint;
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
        private CustomControls.LogLabel logLabel1;
        private System.Windows.Forms.Label labelfps;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelServCmd;
        private System.Windows.Forms.ToolStripMenuItem начатьПриемToolStripMenuItem;
    }
}

