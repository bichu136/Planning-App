namespace Do_An
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
            this.AddJobsBtn = new System.Windows.Forms.Button();
            this.StatisticButton = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WTimeLabel = new System.Windows.Forms.Label();
            this.WTenpfLbl = new System.Windows.Forms.Label();
            this.WsymbLbl = new System.Windows.Forms.Label();
            this.WeatherPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserControlsPanel = new System.Windows.Forms.Panel();
            this.btnPanel.SuspendLayout();
            this.WeatherPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddJobsBtn
            // 
            this.AddJobsBtn.Location = new System.Drawing.Point(3, 3);
            this.AddJobsBtn.Name = "AddJobsBtn";
            this.AddJobsBtn.Size = new System.Drawing.Size(103, 44);
            this.AddJobsBtn.TabIndex = 0;
            this.AddJobsBtn.Text = "Add new job";
            this.AddJobsBtn.UseVisualStyleBackColor = true;
            // 
            // StatisticButton
            // 
            this.StatisticButton.Location = new System.Drawing.Point(112, 2);
            this.StatisticButton.Name = "StatisticButton";
            this.StatisticButton.Size = new System.Drawing.Size(133, 47);
            this.StatisticButton.TabIndex = 0;
            this.StatisticButton.Text = "Show Your result";
            this.StatisticButton.UseVisualStyleBackColor = true;
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.SettingBtn);
            this.btnPanel.Controls.Add(this.StatisticButton);
            this.btnPanel.Controls.Add(this.AddJobsBtn);
            this.btnPanel.Location = new System.Drawing.Point(1195, 252);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(413, 47);
            this.btnPanel.TabIndex = 1;
            this.btnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.btnPanel_Paint);
            // 
            // SettingBtn
            // 
            this.SettingBtn.Location = new System.Drawing.Point(251, 2);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(81, 46);
            this.SettingBtn.TabIndex = 5;
            this.SettingBtn.Text = "Setting.";
            this.SettingBtn.UseVisualStyleBackColor = true;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhiệt độ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời Tiết:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // WTimeLabel
            // 
            this.WTimeLabel.AutoSize = true;
            this.WTimeLabel.Location = new System.Drawing.Point(134, 15);
            this.WTimeLabel.Name = "WTimeLabel";
            this.WTimeLabel.Size = new System.Drawing.Size(46, 17);
            this.WTimeLabel.TabIndex = 3;
            this.WTimeLabel.Text = "label5";
            // 
            // WTenpfLbl
            // 
            this.WTenpfLbl.AutoSize = true;
            this.WTenpfLbl.Location = new System.Drawing.Point(134, 75);
            this.WTenpfLbl.Name = "WTenpfLbl";
            this.WTenpfLbl.Size = new System.Drawing.Size(46, 17);
            this.WTenpfLbl.TabIndex = 4;
            this.WTenpfLbl.Text = "label6";
            // 
            // WsymbLbl
            // 
            this.WsymbLbl.AutoSize = true;
            this.WsymbLbl.Location = new System.Drawing.Point(134, 142);
            this.WsymbLbl.Name = "WsymbLbl";
            this.WsymbLbl.Size = new System.Drawing.Size(46, 17);
            this.WsymbLbl.TabIndex = 5;
            this.WsymbLbl.Text = "label7";
            // 
            // WeatherPanel
            // 
            this.WeatherPanel.Controls.Add(this.WsymbLbl);
            this.WeatherPanel.Controls.Add(this.WTenpfLbl);
            this.WeatherPanel.Controls.Add(this.WTimeLabel);
            this.WeatherPanel.Controls.Add(this.label4);
            this.WeatherPanel.Controls.Add(this.label3);
            this.WeatherPanel.Controls.Add(this.label1);
            this.WeatherPanel.Location = new System.Drawing.Point(1195, 0);
            this.WeatherPanel.Name = "WeatherPanel";
            this.WeatherPanel.Size = new System.Drawing.Size(426, 233);
            this.WeatherPanel.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.calendarToolStripMenuItem,
            this.weatherToolStripMenuItem,
            this.chartToolStripMenuItem,
            this.addJobsToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(85, 627);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.calendarToolStripMenuItem.Text = "Calendar";
            this.calendarToolStripMenuItem.Click += new System.EventHandler(this.calendarToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // addJobsToolStripMenuItem
            // 
            this.addJobsToolStripMenuItem.Name = "addJobsToolStripMenuItem";
            this.addJobsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.addJobsToolStripMenuItem.Text = "AddJobs";
            // 
            // weatherToolStripMenuItem
            // 
            this.weatherToolStripMenuItem.Name = "weatherToolStripMenuItem";
            this.weatherToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.weatherToolStripMenuItem.Text = "Weather";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // UserControlsPanel
            // 
            this.UserControlsPanel.Location = new System.Drawing.Point(88, 0);
            this.UserControlsPanel.Name = "UserControlsPanel";
            this.UserControlsPanel.Size = new System.Drawing.Size(1104, 495);
            this.UserControlsPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1620, 627);
            this.Controls.Add(this.UserControlsPanel);
            this.Controls.Add(this.WeatherPanel);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Planning App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btnPanel.ResumeLayout(false);
            this.WeatherPanel.ResumeLayout(false);
            this.WeatherPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button AddJobsBtn;
        private System.Windows.Forms.Button StatisticButton;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label WTimeLabel;
        private System.Windows.Forms.Label WTenpfLbl;
        private System.Windows.Forms.Label WsymbLbl;
        private System.Windows.Forms.Panel WeatherPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weatherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.Panel UserControlsPanel;
    }
}

