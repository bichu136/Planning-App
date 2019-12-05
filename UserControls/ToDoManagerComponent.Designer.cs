namespace Do_An
{
    partial class ToDoManagerComponent
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
            this.button4 = new System.Windows.Forms.Button();
            this.ShowDailyPanel = new System.Windows.Forms.Panel();
            this.UpdateDailyBtn = new System.Windows.Forms.Button();
            this.DailyDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowEventsBtn = new System.Windows.Forms.Button();
            this.ShowDeadlinesBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeadlineLabel = new System.Windows.Forms.Label();
            this.recordBtn = new System.Windows.Forms.Button();
            this.ShowDailyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(425, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 48);
            this.button4.TabIndex = 9;
            this.button4.Text = "Add Done Jobs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ShowDailyPanel
            // 
            this.ShowDailyPanel.Controls.Add(this.UpdateDailyBtn);
            this.ShowDailyPanel.Controls.Add(this.DailyDataGrid);
            this.ShowDailyPanel.Location = new System.Drawing.Point(3, 3);
            this.ShowDailyPanel.Name = "ShowDailyPanel";
            this.ShowDailyPanel.Size = new System.Drawing.Size(416, 301);
            this.ShowDailyPanel.TabIndex = 8;
            // 
            // UpdateDailyBtn
            // 
            this.UpdateDailyBtn.Location = new System.Drawing.Point(259, 243);
            this.UpdateDailyBtn.Name = "UpdateDailyBtn";
            this.UpdateDailyBtn.Size = new System.Drawing.Size(154, 45);
            this.UpdateDailyBtn.TabIndex = 1;
            this.UpdateDailyBtn.Text = "Update";
            this.UpdateDailyBtn.UseVisualStyleBackColor = true;
            this.UpdateDailyBtn.Click += new System.EventHandler(this.UpdateDailyBtn_Click);
            // 
            // DailyDataGrid
            // 
            this.DailyDataGrid.AllowUserToAddRows = false;
            this.DailyDataGrid.AllowUserToDeleteRows = false;
            this.DailyDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DailyDataGrid.ColumnHeadersHeight = 29;
            this.DailyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DailyDataGrid.Location = new System.Drawing.Point(9, 6);
            this.DailyDataGrid.MultiSelect = false;
            this.DailyDataGrid.Name = "DailyDataGrid";
            this.DailyDataGrid.RowHeadersWidth = 51;
            this.DailyDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DailyDataGrid.RowTemplate.Height = 24;
            this.DailyDataGrid.Size = new System.Drawing.Size(407, 231);
            this.DailyDataGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShowEventsBtn);
            this.panel1.Controls.Add(this.ShowDeadlinesBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DeadlineLabel);
            this.panel1.Location = new System.Drawing.Point(3, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 100);
            this.panel1.TabIndex = 7;
            // 
            // ShowEventsBtn
            // 
            this.ShowEventsBtn.Location = new System.Drawing.Point(491, 51);
            this.ShowEventsBtn.Name = "ShowEventsBtn";
            this.ShowEventsBtn.Size = new System.Drawing.Size(59, 43);
            this.ShowEventsBtn.TabIndex = 1;
            this.ShowEventsBtn.Text = "Show Event";
            this.ShowEventsBtn.UseVisualStyleBackColor = true;
            this.ShowEventsBtn.Click += new System.EventHandler(this.ShowEventsBtn_Click);
            // 
            // ShowDeadlinesBtn
            // 
            this.ShowDeadlinesBtn.Location = new System.Drawing.Point(491, 0);
            this.ShowDeadlinesBtn.Name = "ShowDeadlinesBtn";
            this.ShowDeadlinesBtn.Size = new System.Drawing.Size(59, 45);
            this.ShowDeadlinesBtn.TabIndex = 1;
            this.ShowDeadlinesBtn.Text = "ShowDeadlines";
            this.ShowDeadlinesBtn.UseVisualStyleBackColor = true;
            this.ShowDeadlinesBtn.Click += new System.EventHandler(this.ShowDeadlinesBtn_Click);
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
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(425, 67);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(128, 38);
            this.recordBtn.TabIndex = 6;
            this.recordBtn.Text = "Record Jobs";
            this.recordBtn.UseVisualStyleBackColor = true;
            // 
            // ToDoManagerComponent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ShowDailyPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.recordBtn);
            this.Name = "ToDoManagerComponent";
            this.Size = new System.Drawing.Size(986, 565);
            this.Load += new System.EventHandler(this.ToDoManagerComponent_Load);
            this.ShowDailyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel ShowDailyPanel;
        private System.Windows.Forms.Button UpdateDailyBtn;
        private System.Windows.Forms.DataGridView DailyDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowEventsBtn;
        private System.Windows.Forms.Button ShowDeadlinesBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DeadlineLabel;
        private System.Windows.Forms.Button recordBtn;
    }
}