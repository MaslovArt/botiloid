namespace botiloid.server
{
    partial class Connect
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.NetGroup = new System.Windows.Forms.GroupBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_hostName = new System.Windows.Forms.TextBox();
            this.tb_clientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NetGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Location = new System.Drawing.Point(155, 184);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(170, 37);
            this.buttonConnect.TabIndex = 10;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // NetGroup
            // 
            this.NetGroup.Controls.Add(this.tb_port);
            this.NetGroup.Controls.Add(this.tb_hostName);
            this.NetGroup.Controls.Add(this.tb_clientName);
            this.NetGroup.Controls.Add(this.label3);
            this.NetGroup.Controls.Add(this.label2);
            this.NetGroup.Controls.Add(this.label1);
            this.NetGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NetGroup.Location = new System.Drawing.Point(12, 12);
            this.NetGroup.Name = "NetGroup";
            this.NetGroup.Size = new System.Drawing.Size(313, 166);
            this.NetGroup.TabIndex = 9;
            this.NetGroup.TabStop = false;
            this.NetGroup.Text = "Данные сервера";
            // 
            // tb_port
            // 
            this.tb_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_port.Location = new System.Drawing.Point(127, 116);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(167, 26);
            this.tb_port.TabIndex = 5;
            this.tb_port.Text = "8000";
            // 
            // tb_hostName
            // 
            this.tb_hostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_hostName.Location = new System.Drawing.Point(127, 80);
            this.tb_hostName.Name = "tb_hostName";
            this.tb_hostName.Size = new System.Drawing.Size(167, 26);
            this.tb_hostName.TabIndex = 4;
            this.tb_hostName.Text = "127.0.0.1";
            // 
            // tb_clientName
            // 
            this.tb_clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_clientName.Location = new System.Drawing.Point(127, 44);
            this.tb_clientName.Name = "tb_clientName";
            this.tb_clientName.Size = new System.Drawing.Size(167, 26);
            this.tb_clientName.TabIndex = 3;
            this.tb_clientName.Text = "User228";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(69, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Порт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя хоста:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя клиента:";
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 230);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.NetGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Connect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение к серверу";
            this.NetGroup.ResumeLayout(false);
            this.NetGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox NetGroup;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_hostName;
        private System.Windows.Forms.TextBox tb_clientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}