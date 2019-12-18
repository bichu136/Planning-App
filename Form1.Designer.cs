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
            this.UserControlsPanel = new DevExpress.XtraEditors.PanelControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.UserControlsPanel)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserControlsPanel
            // 
            this.UserControlsPanel.Appearance.BackColor = System.Drawing.Color.White;
            this.UserControlsPanel.Appearance.Options.UseBackColor = true;
            this.UserControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControlsPanel.Location = new System.Drawing.Point(154, 0);
            this.UserControlsPanel.Name = "UserControlsPanel";
            this.UserControlsPanel.Size = new System.Drawing.Size(1185, 587);
            this.UserControlsPanel.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(90)))), ((int)(((byte)(146)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.calendarToolStripMenuItem,
            this.weatherToolStripMenuItem,
            this.chartToolStripMenuItem,
            this.addJobsToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.skinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(154, 587);
            this.menuStrip1.TabIndex = 7;
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mainToolStripMenuItem.Image")));
            this.mainToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(150, 64);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mainToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calendarToolStripMenuItem.Image")));
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(150, 64);
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
            this.weatherToolStripMenuItem.Size = new System.Drawing.Size(150, 64);
            this.weatherToolStripMenuItem.Text = "Weather";
            this.weatherToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.weatherToolStripMenuItem.Click += new System.EventHandler(this.weatherToolStripMenuItem_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chartToolStripMenuItem.Image")));
            this.chartToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(150, 64);
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
            this.addJobsToolStripMenuItem.Size = new System.Drawing.Size(150, 64);
            this.addJobsToolStripMenuItem.Text = "AddJobs";
            this.addJobsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addJobsToolStripMenuItem.Click += new System.EventHandler(this.addJobsToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingToolStripMenuItem.Image")));
            this.settingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(150, 64);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.settingToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // skinToolStripMenuItem
            // 
            this.skinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("skinToolStripMenuItem.Image")));
            this.skinToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.skinToolStripMenuItem.Name = "skinToolStripMenuItem";
            this.skinToolStripMenuItem.Size = new System.Drawing.Size(150, 64);
            this.skinToolStripMenuItem.Text = "Skin";
            this.skinToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.skinToolStripMenuItem.Click += new System.EventHandler(this.skinToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1339, 587);
            this.Controls.Add(this.UserControlsPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
            this.Name = "MainForm";
            this.Text = "Planning App";
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.UserControlsPanel)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private DevExpress.XtraEditors.PanelControl UserControlsPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weatherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skinToolStripMenuItem;
    }
}

