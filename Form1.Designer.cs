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
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.dayGeneratePanel = new System.Windows.Forms.Panel();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.makePlanBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddJobs = new System.Windows.Forms.Button();
            this.recordBtn = new System.Windows.Forms.Button();
            this.calendarPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarPanel
            // 
            this.calendarPanel.Controls.Add(this.dayGeneratePanel);
            this.calendarPanel.Location = new System.Drawing.Point(12, 12);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(526, 292);
            this.calendarPanel.TabIndex = 0;
            this.calendarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CalendarPanel_Paint);
            // 
            // dayGeneratePanel
            // 
            this.dayGeneratePanel.Location = new System.Drawing.Point(61, 58);
            this.dayGeneratePanel.Name = "dayGeneratePanel";
            this.dayGeneratePanel.Size = new System.Drawing.Size(462, 231);
            this.dayGeneratePanel.TabIndex = 0;
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.makePlanBtn);
            this.btnPanel.Controls.Add(this.button2);
            this.btnPanel.Controls.Add(this.AddJobs);
            this.btnPanel.Controls.Add(this.recordBtn);
            this.btnPanel.Location = new System.Drawing.Point(545, 13);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(132, 291);
            this.btnPanel.TabIndex = 1;
            // 
            // makePlanBtn
            // 
            this.makePlanBtn.Location = new System.Drawing.Point(3, 230);
            this.makePlanBtn.Name = "makePlanBtn";
            this.makePlanBtn.Size = new System.Drawing.Size(125, 58);
            this.makePlanBtn.TabIndex = 0;
            this.makePlanBtn.Text = "Create your daily plan";
            this.makePlanBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "Show Your result";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // AddJobs
            // 
            this.AddJobs.Location = new System.Drawing.Point(3, 48);
            this.AddJobs.Name = "AddJobs";
            this.AddJobs.Size = new System.Drawing.Size(125, 38);
            this.AddJobs.TabIndex = 0;
            this.AddJobs.Text = "Add new job";
            this.AddJobs.UseVisualStyleBackColor = true;
            this.AddJobs.Click += new System.EventHandler(this.AddJobs_Click);
            // 
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(4, 4);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(125, 38);
            this.recordBtn.TabIndex = 0;
            this.recordBtn.Text = "Record Jobs";
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.RecordBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 322);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.calendarPanel);
            this.Name = "MainForm";
            this.Text = "Planning App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.calendarPanel.ResumeLayout(false);
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel calendarPanel;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Panel dayGeneratePanel;
        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Button makePlanBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddJobs;
    }
}

