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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserControlsPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.calendarToolStripMenuItem,
            this.weatherToolStripMenuItem,
            this.chartToolStripMenuItem,
            this.addJobsToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(154, 600);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mainToolStripMenuItem.Image")));
            this.mainToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(149, 64);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calendarToolStripMenuItem.Image")));
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(150, 104);
            this.calendarToolStripMenuItem.Text = "Calendar";
            this.calendarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.calendarToolStripMenuItem.Click += new System.EventHandler(this.calendarToolStripMenuItem_Click);
            // 
            // weatherToolStripMenuItem
            // 
            this.weatherToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.weatherToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("weatherToolStripMenuItem.Image")));
            this.weatherToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.weatherToolStripMenuItem.Name = "weatherToolStripMenuItem";
            this.weatherToolStripMenuItem.Size = new System.Drawing.Size(150, 104);
            this.weatherToolStripMenuItem.Text = "Weather";
            this.weatherToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.weatherToolStripMenuItem.Click += new System.EventHandler(this.weatherToolStripMenuItem_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chartToolStripMenuItem.Image")));
            this.chartToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(149, 64);
            this.chartToolStripMenuItem.Text = "Chart";
            this.chartToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chartToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.chartToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // addJobsToolStripMenuItem
            // 
            this.addJobsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addJobsToolStripMenuItem.Image")));
            this.addJobsToolStripMenuItem.Name = "addJobsToolStripMenuItem";
            this.addJobsToolStripMenuItem.Size = new System.Drawing.Size(150, 104);
            this.addJobsToolStripMenuItem.Text = "AddJobs";
            this.addJobsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addJobsToolStripMenuItem.Click += new System.EventHandler(this.addJobsToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // UserControlsPanel
            // 
            this.UserControlsPanel.Location = new System.Drawing.Point(175, 11);
            this.UserControlsPanel.Name = "UserControlsPanel";
            this.UserControlsPanel.Size = new System.Drawing.Size(1315, 577);
            this.UserControlsPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1502, 600);
            this.Controls.Add(this.UserControlsPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Planning App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
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

