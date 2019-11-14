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
            this.AddJobsBtn = new System.Windows.Forms.Button();
            this.StatisticButton = new System.Windows.Forms.Button();
            this.makePlanBtn = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMatrix = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonLastMonth = new System.Windows.Forms.Button();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.buttonSunday = new System.Windows.Forms.Button();
            this.buttonSaturday = new System.Windows.Forms.Button();
            this.buttonFriday = new System.Windows.Forms.Button();
            this.buttonThursday = new System.Windows.Forms.Button();
            this.buttonWednesday = new System.Windows.Forms.Button();
            this.buttonTuesday = new System.Windows.Forms.Button();
            this.buttonMonday = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonToday = new System.Windows.Forms.Button();
            this.dateTimePickerMainForm = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeadlineLabel = new System.Windows.Forms.Label();
            this.WeatherPanel = new System.Windows.Forms.Panel();
            this.ShowDailyPanel = new System.Windows.Forms.Panel();
            this.DailyDataGrid = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WTimeLabel = new System.Windows.Forms.Label();
            this.WTenpfLbl = new System.Windows.Forms.Label();
            this.WsymbLbl = new System.Windows.Forms.Label();
            this.btnPanel.SuspendLayout();
            this.calendarPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.WeatherPanel.SuspendLayout();
            this.ShowDailyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(12, 677);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(128, 38);
            this.recordBtn.TabIndex = 0;
            this.recordBtn.Text = "Record Jobs";
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.RecordBtn_Click);
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
            // makePlanBtn
            // 
            this.makePlanBtn.Location = new System.Drawing.Point(438, 672);
            this.makePlanBtn.Name = "makePlanBtn";
            this.makePlanBtn.Size = new System.Drawing.Size(125, 43);
            this.makePlanBtn.TabIndex = 0;
            this.makePlanBtn.Text = "Create your daily plan";
            this.makePlanBtn.UseVisualStyleBackColor = true;
            this.makePlanBtn.Click += new System.EventHandler(this.makePlanBtn_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.SettingBtn);
            this.btnPanel.Controls.Add(this.StatisticButton);
            this.btnPanel.Controls.Add(this.AddJobsBtn);
            this.btnPanel.Location = new System.Drawing.Point(944, 254);
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
            // calendarPanel
            // 
            this.calendarPanel.Controls.Add(this.panel2);
            this.calendarPanel.Controls.Add(this.panel4);
            this.calendarPanel.Location = new System.Drawing.Point(12, 12);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(913, 543);
            this.calendarPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelMatrix);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(9, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 496);
            this.panel2.TabIndex = 0;
            // 
            // panelMatrix
            // 
            this.panelMatrix.Location = new System.Drawing.Point(102, 61);
            this.panelMatrix.Name = "panelMatrix";
            this.panelMatrix.Size = new System.Drawing.Size(687, 435);
            this.panelMatrix.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonLastMonth);
            this.panel5.Controls.Add(this.buttonNextMonth);
            this.panel5.Controls.Add(this.buttonSunday);
            this.panel5.Controls.Add(this.buttonSaturday);
            this.panel5.Controls.Add(this.buttonFriday);
            this.panel5.Controls.Add(this.buttonThursday);
            this.panel5.Controls.Add(this.buttonWednesday);
            this.panel5.Controls.Add(this.buttonTuesday);
            this.panel5.Controls.Add(this.buttonMonday);
            this.panel5.Location = new System.Drawing.Point(6, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(888, 51);
            this.panel5.TabIndex = 1;
            // 
            // buttonLastMonth
            // 
            this.buttonLastMonth.Location = new System.Drawing.Point(3, 3);
            this.buttonLastMonth.Name = "buttonLastMonth";
            this.buttonLastMonth.Size = new System.Drawing.Size(87, 48);
            this.buttonLastMonth.TabIndex = 8;
            this.buttonLastMonth.Text = "Last Month";
            this.buttonLastMonth.UseVisualStyleBackColor = true;
            this.buttonLastMonth.Click += new System.EventHandler(this.buttonLastMonth_Click);
            // 
            // buttonNextMonth
            // 
            this.buttonNextMonth.Location = new System.Drawing.Point(783, 3);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(101, 48);
            this.buttonNextMonth.TabIndex = 7;
            this.buttonNextMonth.Text = "Next Month";
            this.buttonNextMonth.UseVisualStyleBackColor = true;
            this.buttonNextMonth.Click += new System.EventHandler(this.buttonNextMonth_Click);
            // 
            // buttonSunday
            // 
            this.buttonSunday.Location = new System.Drawing.Point(684, 3);
            this.buttonSunday.Name = "buttonSunday";
            this.buttonSunday.Size = new System.Drawing.Size(93, 48);
            this.buttonSunday.TabIndex = 6;
            this.buttonSunday.Text = "Sunday";
            this.buttonSunday.UseVisualStyleBackColor = true;
            // 
            // buttonSaturday
            // 
            this.buttonSaturday.Location = new System.Drawing.Point(585, 3);
            this.buttonSaturday.Name = "buttonSaturday";
            this.buttonSaturday.Size = new System.Drawing.Size(93, 48);
            this.buttonSaturday.TabIndex = 5;
            this.buttonSaturday.Text = "Saturday";
            this.buttonSaturday.UseVisualStyleBackColor = true;
            // 
            // buttonFriday
            // 
            this.buttonFriday.Location = new System.Drawing.Point(486, 3);
            this.buttonFriday.Name = "buttonFriday";
            this.buttonFriday.Size = new System.Drawing.Size(93, 48);
            this.buttonFriday.TabIndex = 4;
            this.buttonFriday.Text = "Friday";
            this.buttonFriday.UseVisualStyleBackColor = true;
            // 
            // buttonThursday
            // 
            this.buttonThursday.Location = new System.Drawing.Point(387, 3);
            this.buttonThursday.Name = "buttonThursday";
            this.buttonThursday.Size = new System.Drawing.Size(93, 48);
            this.buttonThursday.TabIndex = 3;
            this.buttonThursday.Text = "Thursday";
            this.buttonThursday.UseVisualStyleBackColor = true;
            // 
            // buttonWednesday
            // 
            this.buttonWednesday.Location = new System.Drawing.Point(288, 3);
            this.buttonWednesday.Name = "buttonWednesday";
            this.buttonWednesday.Size = new System.Drawing.Size(93, 48);
            this.buttonWednesday.TabIndex = 2;
            this.buttonWednesday.Text = "Wednesday";
            this.buttonWednesday.UseVisualStyleBackColor = true;
            // 
            // buttonTuesday
            // 
            this.buttonTuesday.Location = new System.Drawing.Point(195, 3);
            this.buttonTuesday.Name = "buttonTuesday";
            this.buttonTuesday.Size = new System.Drawing.Size(93, 48);
            this.buttonTuesday.TabIndex = 1;
            this.buttonTuesday.Text = "Tuesday";
            this.buttonTuesday.UseVisualStyleBackColor = true;
            // 
            // buttonMonday
            // 
            this.buttonMonday.Location = new System.Drawing.Point(96, 3);
            this.buttonMonday.Name = "buttonMonday";
            this.buttonMonday.Size = new System.Drawing.Size(93, 48);
            this.buttonMonday.TabIndex = 0;
            this.buttonMonday.Text = "Monday";
            this.buttonMonday.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonToday);
            this.panel4.Controls.Add(this.dateTimePickerMainForm);
            this.panel4.Location = new System.Drawing.Point(9, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(897, 32);
            this.panel4.TabIndex = 0;
            // 
            // buttonToday
            // 
            this.buttonToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToday.Location = new System.Drawing.Point(705, 0);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(75, 29);
            this.buttonToday.TabIndex = 1;
            this.buttonToday.Text = "Today";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // dateTimePickerMainForm
            // 
            this.dateTimePickerMainForm.Location = new System.Drawing.Point(443, 2);
            this.dateTimePickerMainForm.Name = "dateTimePickerMainForm";
            this.dateTimePickerMainForm.Size = new System.Drawing.Size(227, 22);
            this.dateTimePickerMainForm.TabIndex = 0;
            this.dateTimePickerMainForm.ValueChanged += new System.EventHandler(this.dateTimePickerMainForm_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DeadlineLabel);
            this.panel1.Location = new System.Drawing.Point(10, 563);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 100);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(491, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 43);
            this.button3.TabIndex = 1;
            this.button3.Text = "Show Event";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "ShowDeadlines";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "NextEvent";
            // 
            // DeadlineLabel
            // 
            this.DeadlineLabel.AutoSize = true;
            this.DeadlineLabel.Location = new System.Drawing.Point(3, 14);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(118, 17);
            this.DeadlineLabel.TabIndex = 0;
            this.DeadlineLabel.Text = "Nearest Deadline";
            // 
            // WeatherPanel
            // 
            this.WeatherPanel.Controls.Add(this.WsymbLbl);
            this.WeatherPanel.Controls.Add(this.WTenpfLbl);
            this.WeatherPanel.Controls.Add(this.WTimeLabel);
            this.WeatherPanel.Controls.Add(this.label4);
            this.WeatherPanel.Controls.Add(this.label3);
            this.WeatherPanel.Controls.Add(this.label1);
            this.WeatherPanel.Location = new System.Drawing.Point(931, 15);
            this.WeatherPanel.Name = "WeatherPanel";
            this.WeatherPanel.Size = new System.Drawing.Size(426, 233);
            this.WeatherPanel.TabIndex = 3;
            // 
            // ShowDailyPanel
            // 
            this.ShowDailyPanel.Controls.Add(this.DailyDataGrid);
            this.ShowDailyPanel.Location = new System.Drawing.Point(941, 307);
            this.ShowDailyPanel.Name = "ShowDailyPanel";
            this.ShowDailyPanel.Size = new System.Drawing.Size(416, 240);
            this.ShowDailyPanel.TabIndex = 4;
            // 
            // DailyDataGrid
            // 
            this.DailyDataGrid.AllowUserToAddRows = false;
            this.DailyDataGrid.AllowUserToDeleteRows = false;
            this.DailyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DailyDataGrid.Location = new System.Drawing.Point(6, 6);
            this.DailyDataGrid.MultiSelect = false;
            this.DailyDataGrid.Name = "DailyDataGrid";
            this.DailyDataGrid.RowHeadersWidth = 51;
            this.DailyDataGrid.RowTemplate.Height = 24;
            this.DailyDataGrid.Size = new System.Drawing.Size(407, 231);
            this.DailyDataGrid.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(216, 669);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "Add Done Jobs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1369, 727);
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
            this.calendarPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.WeatherPanel.ResumeLayout(false);
            this.WeatherPanel.PerformLayout();
            this.ShowDailyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Button AddJobsBtn;
        private System.Windows.Forms.Button StatisticButton;
        private System.Windows.Forms.Button makePlanBtn;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Panel calendarPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DeadlineLabel;
        private System.Windows.Forms.Panel WeatherPanel;
        private System.Windows.Forms.Panel ShowDailyPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.DataGridView DailyDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonLastMonth;
        private System.Windows.Forms.Button buttonNextMonth;
        private System.Windows.Forms.Button buttonSunday;
        private System.Windows.Forms.Button buttonSaturday;
        private System.Windows.Forms.Button buttonFriday;
        private System.Windows.Forms.Button buttonThursday;
        private System.Windows.Forms.Button buttonWednesday;
        private System.Windows.Forms.Button buttonTuesday;
        private System.Windows.Forms.Button buttonMonday;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.DateTimePicker dateTimePickerMainForm;
        private System.Windows.Forms.Panel panelMatrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WsymbLbl;
        private System.Windows.Forms.Label WTenpfLbl;
        private System.Windows.Forms.Label WTimeLabel;
    }
}

