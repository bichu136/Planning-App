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
            this.recordBtn = new System.Windows.Forms.Button();
            this.AddJobs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.makePlanBtn = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.WeatherPanel = new System.Windows.Forms.Panel();
            this.ShowDailyPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.UserBtn = new System.Windows.Forms.Button();
            this.btnPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(12, 475);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(128, 38);
            this.recordBtn.TabIndex = 0;
            this.recordBtn.Text = "Record Jobs";
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.RecordBtn_Click);
            // 
            // AddJobs
            // 
            this.AddJobs.Location = new System.Drawing.Point(3, 3);
            this.AddJobs.Name = "AddJobs";
            this.AddJobs.Size = new System.Drawing.Size(56, 38);
            this.AddJobs.TabIndex = 0;
            this.AddJobs.Text = "Add new job";
            this.AddJobs.UseVisualStyleBackColor = true;
            this.AddJobs.Click += new System.EventHandler(this.AddJobs_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "Show Your result";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // makePlanBtn
            // 
            this.makePlanBtn.Location = new System.Drawing.Point(146, 475);
            this.makePlanBtn.Name = "makePlanBtn";
            this.makePlanBtn.Size = new System.Drawing.Size(125, 43);
            this.makePlanBtn.TabIndex = 0;
            this.makePlanBtn.Text = "Create your daily plan";
            this.makePlanBtn.UseVisualStyleBackColor = true;
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.UserBtn);
            this.btnPanel.Controls.Add(this.button2);
            this.btnPanel.Controls.Add(this.AddJobs);
            this.btnPanel.Location = new System.Drawing.Point(587, 128);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(200, 47);
            this.btnPanel.TabIndex = 1;
            this.btnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.btnPanel_Paint);
            // 
            // calendarPanel
            // 
            this.calendarPanel.Location = new System.Drawing.Point(12, 12);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(554, 330);
            this.calendarPanel.TabIndex = 0;
            this.calendarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CalendarPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 43);
            this.button3.TabIndex = 1;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // WeatherPanel
            // 
            this.WeatherPanel.Location = new System.Drawing.Point(587, 13);
            this.WeatherPanel.Name = "WeatherPanel";
            this.WeatherPanel.Size = new System.Drawing.Size(200, 100);
            this.WeatherPanel.TabIndex = 3;
            // 
            // ShowDailyPanel
            // 
            this.ShowDailyPanel.Location = new System.Drawing.Point(587, 209);
            this.ShowDailyPanel.Name = "ShowDailyPanel";
            this.ShowDailyPanel.Size = new System.Drawing.Size(200, 133);
            this.ShowDailyPanel.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(277, 475);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "Add Done Jobs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UserBtn
            // 
            this.UserBtn.Location = new System.Drawing.Point(133, -2);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(64, 46);
            this.UserBtn.TabIndex = 5;
            this.UserBtn.Text = "User";
            this.UserBtn.UseVisualStyleBackColor = true;
            this.UserBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 525);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ShowDailyPanel);
            this.Controls.Add(this.makePlanBtn);
            this.Controls.Add(this.WeatherPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.recordBtn);
            this.Controls.Add(this.calendarPanel);
            this.Name = "MainForm";
            this.Text = "Planning App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btnPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Button AddJobs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button makePlanBtn;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Panel calendarPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel WeatherPanel;
        private System.Windows.Forms.Panel ShowDailyPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button UserBtn;
    }
}

