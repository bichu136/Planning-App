namespace Do_An
{
    partial class DoingThings
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
            this.UnitPanel = new System.Windows.Forms.Panel();
            this.HasPlanChkBox = new System.Windows.Forms.CheckBox();
            this.UnitLbl = new System.Windows.Forms.Label();
            this.CurrentTxtBox = new System.Windows.Forms.TextBox();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.InformPanel = new System.Windows.Forms.Panel();
            this.StatusLbl1 = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.ValueCurrentLbl = new System.Windows.Forms.Label();
            this.CurrentLbl = new System.Windows.Forms.Label();
            this.StatPanel = new System.Windows.Forms.Panel();
            this.NameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameCbBox = new System.Windows.Forms.ComboBox();
            this.TypeCbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnitPanel.SuspendLayout();
            this.InformPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnitPanel
            // 
            this.UnitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnitPanel.Controls.Add(this.HasPlanChkBox);
            this.UnitPanel.Controls.Add(this.UnitLbl);
            this.UnitPanel.Controls.Add(this.CurrentTxtBox);
            this.UnitPanel.Location = new System.Drawing.Point(12, 388);
            this.UnitPanel.Name = "UnitPanel";
            this.UnitPanel.Size = new System.Drawing.Size(441, 57);
            this.UnitPanel.TabIndex = 0;
            // 
            // HasPlanChkBox
            // 
            this.HasPlanChkBox.AutoSize = true;
            this.HasPlanChkBox.Location = new System.Drawing.Point(29, 17);
            this.HasPlanChkBox.Name = "HasPlanChkBox";
            this.HasPlanChkBox.Size = new System.Drawing.Size(114, 21);
            this.HasPlanChkBox.TabIndex = 4;
            this.HasPlanChkBox.Text = "Has a plan??";
            this.HasPlanChkBox.UseVisualStyleBackColor = true;
            // 
            // UnitLbl
            // 
            this.UnitLbl.AutoSize = true;
            this.UnitLbl.Location = new System.Drawing.Point(365, 19);
            this.UnitLbl.Name = "UnitLbl";
            this.UnitLbl.Size = new System.Drawing.Size(52, 17);
            this.UnitLbl.TabIndex = 2;
            this.UnitLbl.Text = "UnitLbl";
            // 
            // CurrentTxtBox
            // 
            this.CurrentTxtBox.Location = new System.Drawing.Point(259, 16);
            this.CurrentTxtBox.Name = "CurrentTxtBox";
            this.CurrentTxtBox.Size = new System.Drawing.Size(100, 22);
            this.CurrentTxtBox.TabIndex = 1;
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(12, 451);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(168, 68);
            this.DoneBtn.TabIndex = 1;
            this.DoneBtn.Text = "Done";
            this.DoneBtn.UseVisualStyleBackColor = true;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // InformPanel
            // 
            this.InformPanel.Controls.Add(this.StatusLbl1);
            this.InformPanel.Controls.Add(this.StatusLbl);
            this.InformPanel.Controls.Add(this.ValueCurrentLbl);
            this.InformPanel.Controls.Add(this.CurrentLbl);
            this.InformPanel.Controls.Add(this.StatPanel);
            this.InformPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InformPanel.Location = new System.Drawing.Point(460, 13);
            this.InformPanel.Name = "InformPanel";
            this.InformPanel.Size = new System.Drawing.Size(467, 513);
            this.InformPanel.TabIndex = 2;
            this.InformPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InformPanel_Paint);
            // 
            // StatusLbl1
            // 
            this.StatusLbl1.AutoSize = true;
            this.StatusLbl1.Location = new System.Drawing.Point(291, 11);
            this.StatusLbl1.Name = "StatusLbl1";
            this.StatusLbl1.Size = new System.Drawing.Size(48, 17);
            this.StatusLbl1.TabIndex = 4;
            this.StatusLbl1.Text = "Status";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(345, 11);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(62, 17);
            this.StatusLbl.TabIndex = 4;
            this.StatusLbl.Text = "Ongoing";
            // 
            // ValueCurrentLbl
            // 
            this.ValueCurrentLbl.AutoSize = true;
            this.ValueCurrentLbl.Location = new System.Drawing.Point(116, 11);
            this.ValueCurrentLbl.Name = "ValueCurrentLbl";
            this.ValueCurrentLbl.Size = new System.Drawing.Size(30, 17);
            this.ValueCurrentLbl.TabIndex = 4;
            this.ValueCurrentLbl.Text = "X/X";
            // 
            // CurrentLbl
            // 
            this.CurrentLbl.AutoSize = true;
            this.CurrentLbl.Location = new System.Drawing.Point(18, 11);
            this.CurrentLbl.Name = "CurrentLbl";
            this.CurrentLbl.Size = new System.Drawing.Size(55, 17);
            this.CurrentLbl.TabIndex = 4;
            this.CurrentLbl.Text = "Current";
            // 
            // StatPanel
            // 
            this.StatPanel.Location = new System.Drawing.Point(3, 48);
            this.StatPanel.Name = "StatPanel";
            this.StatPanel.Size = new System.Drawing.Size(441, 462);
            this.StatPanel.TabIndex = 3;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLbl.Location = new System.Drawing.Point(13, 50);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(45, 17);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // NameCbBox
            // 
            this.NameCbBox.FormattingEnabled = true;
            this.NameCbBox.Location = new System.Drawing.Point(64, 46);
            this.NameCbBox.Name = "NameCbBox";
            this.NameCbBox.Size = new System.Drawing.Size(366, 24);
            this.NameCbBox.TabIndex = 0;
            this.NameCbBox.SelectedIndexChanged += new System.EventHandler(this.NameCbBox_SelectedIndexChanged);
            this.NameCbBox.DataSourceChanged += new System.EventHandler(this.NamDS_Changed);
            // 
            // TypeCbBox
            // 
            this.TypeCbBox.FormattingEnabled = true;
            this.TypeCbBox.Location = new System.Drawing.Point(64, 13);
            this.TypeCbBox.Name = "TypeCbBox";
            this.TypeCbBox.Size = new System.Drawing.Size(366, 24);
            this.TypeCbBox.TabIndex = 0;
            this.TypeCbBox.SelectedIndexChanged += new System.EventHandler(this.TypeCbBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Timer";
            // 
            // DoingThings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InformPanel);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.UnitPanel);
            this.Controls.Add(this.TypeCbBox);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.NameCbBox);
            this.Controls.Add(this.label1);
            this.Name = "DoingThings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new Record";
            this.UnitPanel.ResumeLayout(false);
            this.UnitPanel.PerformLayout();
            this.InformPanel.ResumeLayout(false);
            this.InformPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UnitPanel;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.Panel InformPanel;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NameCbBox;
        private System.Windows.Forms.ComboBox TypeCbBox;
        private System.Windows.Forms.Label StatusLbl1;
        private System.Windows.Forms.Label CurrentLbl;
        private System.Windows.Forms.Panel StatPanel;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label ValueCurrentLbl;
        private System.Windows.Forms.Label UnitLbl;
        private System.Windows.Forms.TextBox CurrentTxtBox;
        private System.Windows.Forms.CheckBox HasPlanChkBox;
        private System.Windows.Forms.Label label2;
    }
}