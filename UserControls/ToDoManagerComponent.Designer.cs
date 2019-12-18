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
            this.ShowDailyPanel = new DevExpress.XtraEditors.PanelControl();
            this.UpdateDailyBtn = new DevExpress.XtraEditors.SimpleButton();
            this.DailyDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowEventsBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ShowDeadlinesBtn = new DevExpress.XtraEditors.SimpleButton();
            this.EventLabel = new DevExpress.XtraEditors.LabelControl();
            this.DeadlineLabel = new DevExpress.XtraEditors.LabelControl();
            this.AddDoneJobbtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDailyPanel)).BeginInit();
            this.ShowDailyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowDailyPanel
            // 
            this.ShowDailyPanel.AutoSize = true;
            this.ShowDailyPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ShowDailyPanel.Controls.Add(this.UpdateDailyBtn);
            this.ShowDailyPanel.Controls.Add(this.DailyDataGrid);
            this.ShowDailyPanel.Location = new System.Drawing.Point(14, 3);
            this.ShowDailyPanel.Name = "ShowDailyPanel";
            this.ShowDailyPanel.Size = new System.Drawing.Size(915, 312);
            this.ShowDailyPanel.TabIndex = 8;
            // 
            // UpdateDailyBtn
            // 
            this.UpdateDailyBtn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDailyBtn.Appearance.Options.UseFont = true;
            this.UpdateDailyBtn.AutoSize = true;
            this.UpdateDailyBtn.Location = new System.Drawing.Point(727, 253);
            this.UpdateDailyBtn.Name = "UpdateDailyBtn";
            this.UpdateDailyBtn.Size = new System.Drawing.Size(88, 34);
            this.UpdateDailyBtn.TabIndex = 1;
            this.UpdateDailyBtn.Text = "Update";
            this.UpdateDailyBtn.Click += new System.EventHandler(this.UpdateDailyBtn_Click);
            // 
            // DailyDataGrid
            // 
            this.DailyDataGrid.AllowUserToAddRows = false;
            this.DailyDataGrid.AllowUserToDeleteRows = false;
            this.DailyDataGrid.AllowUserToResizeColumns = false;
            this.DailyDataGrid.AllowUserToResizeRows = false;
            this.DailyDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DailyDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DailyDataGrid.ColumnHeadersHeight = 29;
            this.DailyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DailyDataGrid.Location = new System.Drawing.Point(9, 6);
            this.DailyDataGrid.MultiSelect = false;
            this.DailyDataGrid.Name = "DailyDataGrid";
            this.DailyDataGrid.RowHeadersWidth = 51;
            this.DailyDataGrid.RowTemplate.Height = 24;
            this.DailyDataGrid.Size = new System.Drawing.Size(895, 231);
            this.DailyDataGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.ShowEventsBtn);
            this.panel1.Controls.Add(this.ShowDeadlinesBtn);
            this.panel1.Controls.Add(this.EventLabel);
            this.panel1.Controls.Add(this.DeadlineLabel);
            this.panel1.Location = new System.Drawing.Point(101, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 179);
            this.panel1.TabIndex = 7;
            // 
            // ShowEventsBtn
            // 
            this.ShowEventsBtn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEventsBtn.Appearance.Options.UseFont = true;
            this.ShowEventsBtn.AutoSize = true;
            this.ShowEventsBtn.Location = new System.Drawing.Point(773, 100);
            this.ShowEventsBtn.Name = "ShowEventsBtn";
            this.ShowEventsBtn.Size = new System.Drawing.Size(142, 34);
            this.ShowEventsBtn.TabIndex = 1;
            this.ShowEventsBtn.Text = "Show Event";
            this.ShowEventsBtn.Click += new System.EventHandler(this.ShowEventsBtn_Click);
            // 
            // ShowDeadlinesBtn
            // 
            this.ShowDeadlinesBtn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDeadlinesBtn.Appearance.Options.UseFont = true;
            this.ShowDeadlinesBtn.AutoSize = true;
            this.ShowDeadlinesBtn.Location = new System.Drawing.Point(764, 34);
            this.ShowDeadlinesBtn.Name = "ShowDeadlinesBtn";
            this.ShowDeadlinesBtn.Size = new System.Drawing.Size(190, 34);
            this.ShowDeadlinesBtn.TabIndex = 1;
            this.ShowDeadlinesBtn.Text = "Show Deadlines";
            this.ShowDeadlinesBtn.Click += new System.EventHandler(this.ShowDeadlinesBtn_Click);
            // 
            // EventLabel
            // 
            this.EventLabel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventLabel.Appearance.Options.UseFont = true;
            this.EventLabel.Location = new System.Drawing.Point(30, 107);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(116, 29);
            this.EventLabel.TabIndex = 0;
            this.EventLabel.Text = "NextEvent";
            // 
            // DeadlineLabel
            // 
            this.DeadlineLabel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadlineLabel.Appearance.Options.UseFont = true;
            this.DeadlineLabel.Location = new System.Drawing.Point(30, 39);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(195, 29);
            this.DeadlineLabel.TabIndex = 0;
            this.DeadlineLabel.Text = "Nearest Deadline";
            // 
            // AddDoneJobbtn
            // 
            this.AddDoneJobbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDoneJobbtn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDoneJobbtn.Appearance.Options.UseFont = true;
            this.AddDoneJobbtn.AutoSize = true;
            this.AddDoneJobbtn.Location = new System.Drawing.Point(970, 71);
            this.AddDoneJobbtn.Name = "AddDoneJobbtn";
            this.AddDoneJobbtn.Size = new System.Drawing.Size(180, 34);
            this.AddDoneJobbtn.TabIndex = 9;
            this.AddDoneJobbtn.Text = "Add Done Jobs";
            this.AddDoneJobbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // ToDoManagerComponent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.AddDoneJobbtn);
            this.Controls.Add(this.ShowDailyPanel);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1185, 549);
            this.Name = "ToDoManagerComponent";
            this.Size = new System.Drawing.Size(1217, 567);
            this.Load += new System.EventHandler(this.ToDoManagerComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDailyPanel)).EndInit();
            this.ShowDailyPanel.ResumeLayout(false);
            this.ShowDailyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
        private DevExpress.XtraEditors.PanelControl ShowDailyPanel;
        private DevExpress.XtraEditors.SimpleButton UpdateDailyBtn;
        private System.Windows.Forms.DataGridView DailyDataGrid;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton ShowEventsBtn;
        private DevExpress.XtraEditors.SimpleButton ShowDeadlinesBtn;
        private DevExpress.XtraEditors.LabelControl EventLabel;
        private DevExpress.XtraEditors.LabelControl DeadlineLabel;
        private DevExpress.XtraEditors.SimpleButton AddDoneJobbtn;
    }
}