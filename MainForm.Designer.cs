namespace PopDownloader
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPOPHost = new System.Windows.Forms.TextBox();
            this.textBoxPOPLogin = new System.Windows.Forms.TextBox();
            this.textBoxPOPPassword = new System.Windows.Forms.TextBox();
            this.numericUpDownPOPPort = new System.Windows.Forms.NumericUpDown();
            this.checkBoxPOPUseSSL = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDBPassword = new System.Windows.Forms.TextBox();
            this.textBoxDBLogin = new System.Windows.Forms.TextBox();
            this.textBoxDBName = new System.Windows.Forms.TextBox();
            this.textBoxDBHost = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPOPPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "hostname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "useSsl:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "password:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(272, 183);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(353, 183);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPOPHost);
            this.groupBox1.Controls.Add(this.textBoxPOPLogin);
            this.groupBox1.Controls.Add(this.textBoxPOPPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownPOPPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxPOPUseSSL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 154);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "POP3 Settings";
            // 
            // textBoxPOPHost
            // 
            this.textBoxPOPHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PopDownloader.Properties.Settings.Default, "pop_host", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPOPHost.Location = new System.Drawing.Point(85, 19);
            this.textBoxPOPHost.Name = "textBoxPOPHost";
            this.textBoxPOPHost.Size = new System.Drawing.Size(100, 20);
            this.textBoxPOPHost.TabIndex = 0;
            this.textBoxPOPHost.Text = global::PopDownloader.Properties.Settings.Default.pop_host;
            // 
            // textBoxPOPLogin
            // 
            this.textBoxPOPLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PopDownloader.Properties.Settings.Default, "pop_user", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPOPLogin.Location = new System.Drawing.Point(85, 93);
            this.textBoxPOPLogin.Name = "textBoxPOPLogin";
            this.textBoxPOPLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxPOPLogin.TabIndex = 3;
            this.textBoxPOPLogin.Text = global::PopDownloader.Properties.Settings.Default.pop_user;
            // 
            // textBoxPOPPassword
            // 
            this.textBoxPOPPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PopDownloader.Properties.Settings.Default, "pop_pwd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPOPPassword.Location = new System.Drawing.Point(85, 119);
            this.textBoxPOPPassword.Name = "textBoxPOPPassword";
            this.textBoxPOPPassword.PasswordChar = '*';
            this.textBoxPOPPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPOPPassword.TabIndex = 4;
            this.textBoxPOPPassword.Text = global::PopDownloader.Properties.Settings.Default.pop_pwd;
            // 
            // numericUpDownPOPPort
            // 
            this.numericUpDownPOPPort.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PopDownloader.Properties.Settings.Default, "pop_port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownPOPPort.Location = new System.Drawing.Point(85, 47);
            this.numericUpDownPOPPort.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownPOPPort.Name = "numericUpDownPOPPort";
            this.numericUpDownPOPPort.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownPOPPort.TabIndex = 1;
            this.numericUpDownPOPPort.Value = global::PopDownloader.Properties.Settings.Default.pop_port;
            // 
            // checkBoxPOPUseSSL
            // 
            this.checkBoxPOPUseSSL.AutoSize = true;
            this.checkBoxPOPUseSSL.Checked = global::PopDownloader.Properties.Settings.Default.pop_ssl;
            this.checkBoxPOPUseSSL.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PopDownloader.Properties.Settings.Default, "pop_ssl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxPOPUseSSL.Location = new System.Drawing.Point(85, 73);
            this.checkBoxPOPUseSSL.Name = "checkBoxPOPUseSSL";
            this.checkBoxPOPUseSSL.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPOPUseSSL.TabIndex = 2;
            this.checkBoxPOPUseSSL.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxDBPassword);
            this.groupBox2.Controls.Add(this.textBoxDBLogin);
            this.groupBox2.Controls.Add(this.textBoxDBName);
            this.groupBox2.Controls.Add(this.textBoxDBHost);
            this.groupBox2.Location = new System.Drawing.Point(228, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 154);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataBase Settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "database:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "hostname:";
            // 
            // textBoxDBPassword
            // 
            this.textBoxDBPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PopDownloader.Properties.Settings.Default, "db_pwd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDBPassword.Location = new System.Drawing.Point(85, 96);
            this.textBoxDBPassword.Name = "textBoxDBPassword";
            this.textBoxDBPassword.PasswordChar = '*';
            this.textBoxDBPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxDBPassword.TabIndex = 3;
            this.textBoxDBPassword.Text = global::PopDownloader.Properties.Settings.Default.db_pwd;
            // 
            // textBoxDBLogin
            // 
            this.textBoxDBLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PopDownloader.Properties.Settings.Default, "db_user", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDBLogin.Location = new System.Drawing.Point(85, 70);
            this.textBoxDBLogin.Name = "textBoxDBLogin";
            this.textBoxDBLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxDBLogin.TabIndex = 2;
            this.textBoxDBLogin.Text = global::PopDownloader.Properties.Settings.Default.db_user;
            // 
            // textBoxDBName
            // 
            this.textBoxDBName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PopDownloader.Properties.Settings.Default, "db_name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDBName.Location = new System.Drawing.Point(85, 44);
            this.textBoxDBName.Name = "textBoxDBName";
            this.textBoxDBName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDBName.TabIndex = 1;
            this.textBoxDBName.Text = global::PopDownloader.Properties.Settings.Default.db_name;
            // 
            // textBoxDBHost
            // 
            this.textBoxDBHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PopDownloader.Properties.Settings.Default, "db_host", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDBHost.Location = new System.Drawing.Point(85, 19);
            this.textBoxDBHost.Name = "textBoxDBHost";
            this.textBoxDBHost.Size = new System.Drawing.Size(100, 20);
            this.textBoxDBHost.TabIndex = 0;
            this.textBoxDBHost.Text = global::PopDownloader.Properties.Settings.Default.db_host;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(52, 183);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 220);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pop3 Downloader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPOPPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPOPHost;
        private System.Windows.Forms.TextBox textBoxPOPLogin;
        private System.Windows.Forms.TextBox textBoxPOPPassword;
        private System.Windows.Forms.NumericUpDown numericUpDownPOPPort;
        private System.Windows.Forms.CheckBox checkBoxPOPUseSSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDBPassword;
        private System.Windows.Forms.TextBox textBoxDBLogin;
        private System.Windows.Forms.TextBox textBoxDBName;
        private System.Windows.Forms.TextBox textBoxDBHost;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

