namespace Do_An
{
    partial class CalendarComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProjectDgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EventDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            this.calendarPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventDgv)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarPanel
            // 
            this.calendarPanel.Controls.Add(this.panel2);
            this.calendarPanel.Controls.Add(this.panel4);
            this.calendarPanel.Location = new System.Drawing.Point(12, 12);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(1202, 543);
            this.calendarPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panelMatrix);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(9, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1175, 496);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProjectDgv);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(800, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 201);
            this.panel3.TabIndex = 4;
            // 
            // ProjectDgv
            // 
            this.ProjectDgv.AllowUserToAddRows = false;
            this.ProjectDgv.AllowUserToDeleteRows = false;
            this.ProjectDgv.AllowUserToResizeColumns = false;
            this.ProjectDgv.AllowUserToResizeRows = false;
            this.ProjectDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProjectDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProjectDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectDgv.Location = new System.Drawing.Point(0, 20);
            this.ProjectDgv.Name = "ProjectDgv";
            this.ProjectDgv.ReadOnly = true;
            this.ProjectDgv.RowHeadersWidth = 51;
            this.ProjectDgv.RowTemplate.Height = 24;
            this.ProjectDgv.Size = new System.Drawing.Size(366, 179);
            this.ProjectDgv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project On month";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.EventDgv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(795, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 230);
            this.panel1.TabIndex = 3;
            // 
            // EventDgv
            // 
            this.EventDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDgv.Location = new System.Drawing.Point(4, 21);
            this.EventDgv.Name = "EventDgv";
            this.EventDgv.RowHeadersWidth = 51;
            this.EventDgv.RowTemplate.Height = 24;
            this.EventDgv.Size = new System.Drawing.Size(366, 214);
            this.EventDgv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event OnSelected Date";
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
            this.panel5.Size = new System.Drawing.Size(948, 51);
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
            this.buttonNextMonth.Location = new System.Drawing.Point(789, 3);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(101, 48);
            this.buttonNextMonth.TabIndex = 7;
            this.buttonNextMonth.Text = "Next Month";
            this.buttonNextMonth.UseVisualStyleBackColor = true;
            this.buttonNextMonth.Click += new System.EventHandler(this.buttonNextMonth_Click);
            // 
            // buttonSunday
            // 
            this.buttonSunday.Location = new System.Drawing.Point(690, 3);
            this.buttonSunday.Name = "buttonSunday";
            this.buttonSunday.Size = new System.Drawing.Size(93, 48);
            this.buttonSunday.TabIndex = 6;
            this.buttonSunday.Text = "Sunday";
            this.buttonSunday.UseVisualStyleBackColor = true;
            // 
            // buttonSaturday
            // 
            this.buttonSaturday.Location = new System.Drawing.Point(591, 3);
            this.buttonSaturday.Name = "buttonSaturday";
            this.buttonSaturday.Size = new System.Drawing.Size(93, 48);
            this.buttonSaturday.TabIndex = 5;
            this.buttonSaturday.Text = "Saturday";
            this.buttonSaturday.UseVisualStyleBackColor = true;
            // 
            // buttonFriday
            // 
            this.buttonFriday.Location = new System.Drawing.Point(492, 3);
            this.buttonFriday.Name = "buttonFriday";
            this.buttonFriday.Size = new System.Drawing.Size(93, 48);
            this.buttonFriday.TabIndex = 4;
            this.buttonFriday.Text = "Friday";
            this.buttonFriday.UseVisualStyleBackColor = true;
            // 
            // buttonThursday
            // 
            this.buttonThursday.Location = new System.Drawing.Point(393, 3);
            this.buttonThursday.Name = "buttonThursday";
            this.buttonThursday.Size = new System.Drawing.Size(93, 48);
            this.buttonThursday.TabIndex = 3;
            this.buttonThursday.Text = "Thursday";
            this.buttonThursday.UseVisualStyleBackColor = true;
            // 
            // buttonWednesday
            // 
            this.buttonWednesday.Location = new System.Drawing.Point(294, 3);
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
            this.buttonMonday.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
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
            this.panel4.Size = new System.Drawing.Size(957, 32);
            this.panel4.TabIndex = 0;
            // 
            // buttonToday
            // 
            this.buttonToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToday.Location = new System.Drawing.Point(242, 0);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(75, 29);
            this.buttonToday.TabIndex = 1;
            this.buttonToday.Text = "Today";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // dateTimePickerMainForm
            // 
            this.dateTimePickerMainForm.Location = new System.Drawing.Point(9, 2);
            this.dateTimePickerMainForm.Name = "dateTimePickerMainForm";
            this.dateTimePickerMainForm.Size = new System.Drawing.Size(227, 22);
            this.dateTimePickerMainForm.TabIndex = 0;
            this.dateTimePickerMainForm.ValueChanged += new System.EventHandler(this.dateTimePickerMainForm_ValueChanged);
            // 
            // CalendarComponent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.calendarPanel);
            this.Name = "CalendarComponent";
            this.Size = new System.Drawing.Size(1217, 567);
            this.calendarPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventDgv)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel calendarPanel;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView EventDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ProjectDgv;
        private System.Windows.Forms.Label label2;
    }
    #endregion

}
