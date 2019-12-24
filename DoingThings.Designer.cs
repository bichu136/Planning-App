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
            this.UnitLbl = new DevExpress.XtraEditors.LabelControl();
            this.CurrentTxtBox = new System.Windows.Forms.TextBox();
            this.DoneBtn = new DevExpress.XtraEditors.SimpleButton();
            this.InformPanel = new System.Windows.Forms.Panel();
            this.Goal_DeadlineLbl = new DevExpress.XtraEditors.LabelControl();
            this.ValueGoal_DeadlineLbl = new DevExpress.XtraEditors.LabelControl();
            this.ValueCurrentBtn = new DevExpress.XtraEditors.LabelControl();
            this.CurrentLbl = new DevExpress.XtraEditors.LabelControl();
            this.StatPanel = new System.Windows.Forms.Panel();
            this.NameLbl = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.NameCbBox = new System.Windows.Forms.ComboBox();
            this.TypeCbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControlGenneral = new DevExpress.XtraEditors.PanelControl();
            //((System.ComponentModel.ISupportInitialize)(this.UnitPanel)).BeginInit();
            this.UnitPanel.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.InformPanel)).BeginInit();
            this.InformPanel.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.StatPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGenneral)).BeginInit();
            this.panelControlGenneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnitPanel
            // 
            this.UnitPanel.Controls.Add(this.HasPlanChkBox);
            this.UnitPanel.Controls.Add(this.UnitLbl);
            this.UnitPanel.Controls.Add(this.CurrentTxtBox);
            this.UnitPanel.Location = new System.Drawing.Point(26, 384);
            this.UnitPanel.Name = "UnitPanel";
            this.UnitPanel.Size = new System.Drawing.Size(386, 57);
            this.UnitPanel.TabIndex = 0;
            // 
            // HasPlanChkBox
            // 
            this.HasPlanChkBox.AutoSize = true;
            this.HasPlanChkBox.Location = new System.Drawing.Point(25, 17);
            this.HasPlanChkBox.Name = "HasPlanChkBox";
            this.HasPlanChkBox.Size = new System.Drawing.Size(106, 21);
            this.HasPlanChkBox.TabIndex = 4;
            this.HasPlanChkBox.Text = "Has a plan??";
            this.HasPlanChkBox.UseVisualStyleBackColor = true;
            // 
            // UnitLbl
            // 
            this.UnitLbl.Location = new System.Drawing.Point(319, 19);
            this.UnitLbl.Name = "UnitLbl";
            this.UnitLbl.Size = new System.Drawing.Size(38, 16);
            this.UnitLbl.TabIndex = 2;
            this.UnitLbl.Text = "UnitLbl";
            // 
            // CurrentTxtBox
            // 
            this.CurrentTxtBox.Location = new System.Drawing.Point(227, 16);
            this.CurrentTxtBox.Name = "CurrentTxtBox";
            this.CurrentTxtBox.Size = new System.Drawing.Size(88, 23);
            this.CurrentTxtBox.TabIndex = 1;
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(12, 447);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(147, 68);
            this.DoneBtn.TabIndex = 1;
            this.DoneBtn.Text = "Done";
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // InformPanel
            // 
            //this.InformPanel.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            //this.InformPanel.Appearance.Options.UseForeColor = true;
            this.InformPanel.Controls.Add(this.Goal_DeadlineLbl);
            this.InformPanel.Controls.Add(this.ValueGoal_DeadlineLbl);
            this.InformPanel.Controls.Add(this.ValueCurrentBtn);
            this.InformPanel.Controls.Add(this.CurrentLbl);
            this.InformPanel.Controls.Add(this.StatPanel);
            this.InformPanel.Controls.Add(this.NameLbl);
            this.InformPanel.Controls.Add(this.label1);
            this.InformPanel.Controls.Add(this.NameCbBox);
            this.InformPanel.Controls.Add(this.TypeCbBox);
            this.InformPanel.Location = new System.Drawing.Point(418, 12);
            this.InformPanel.Name = "InformPanel";
            this.InformPanel.Size = new System.Drawing.Size(485, 507);
            this.InformPanel.TabIndex = 2;
            // 
            // Goal_DeadlineLbl
            // 
            this.Goal_DeadlineLbl.Location = new System.Drawing.Point(373, 95);
            this.Goal_DeadlineLbl.Name = "Goal_DeadlineLbl";
            this.Goal_DeadlineLbl.Size = new System.Drawing.Size(29, 16);
            this.Goal_DeadlineLbl.TabIndex = 4;
            this.Goal_DeadlineLbl.Text = "None";
            // 
            // ValueGoal_DeadlineLbl
            // 
            this.ValueGoal_DeadlineLbl.Location = new System.Drawing.Point(418, 95);
            this.ValueGoal_DeadlineLbl.Name = "ValueGoal_DeadlineLbl";
            this.ValueGoal_DeadlineLbl.Size = new System.Drawing.Size(29, 16);
            this.ValueGoal_DeadlineLbl.TabIndex = 4;
            this.ValueGoal_DeadlineLbl.Text = "None";
            // 
            // ValueCurrentBtn
            // 
            this.ValueCurrentBtn.Location = new System.Drawing.Point(418, 68);
            this.ValueCurrentBtn.Name = "ValueCurrentBtn";
            this.ValueCurrentBtn.Size = new System.Drawing.Size(29, 16);
            this.ValueCurrentBtn.TabIndex = 4;
            this.ValueCurrentBtn.Text = "None";
            // 
            // CurrentLbl
            // 
            this.CurrentLbl.Location = new System.Drawing.Point(373, 69);
            this.CurrentLbl.Name = "CurrentLbl";
            this.CurrentLbl.Size = new System.Drawing.Size(29, 16);
            this.CurrentLbl.TabIndex = 4;
            this.CurrentLbl.Text = "None";
            // 
            // StatPanel
            // 
            this.StatPanel.Location = new System.Drawing.Point(3, 95);
            this.StatPanel.Name = "StatPanel";
            this.StatPanel.Size = new System.Drawing.Size(348, 415);
            this.StatPanel.TabIndex = 3;
            // 
            // NameLbl
            // 
            this.NameLbl.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLbl.Appearance.Options.UseForeColor = true;
            this.NameLbl.Location = new System.Drawing.Point(3, 69);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(33, 16);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name";
            // 
            // label1
            // 
            this.label1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Appearance.Options.UseForeColor = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // NameCbBox
            // 
            this.NameCbBox.FormattingEnabled = true;
            this.NameCbBox.Location = new System.Drawing.Point(47, 65);
            this.NameCbBox.Name = "NameCbBox";
            this.NameCbBox.Size = new System.Drawing.Size(321, 24);
            this.NameCbBox.TabIndex = 0;
            this.NameCbBox.SelectedIndexChanged += new System.EventHandler(this.NameCbBox_SelectedIndexChanged);
            // 
            // TypeCbBox
            // 
            this.TypeCbBox.FormattingEnabled = true;
            this.TypeCbBox.Location = new System.Drawing.Point(47, 32);
            this.TypeCbBox.Name = "TypeCbBox";
            this.TypeCbBox.Size = new System.Drawing.Size(321, 24);
            this.TypeCbBox.TabIndex = 0;
            this.TypeCbBox.SelectedIndexChanged += new System.EventHandler(this.TypeCbBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Timer";
            // 
            // panelControlGenneral
            // 
            this.panelControlGenneral.Controls.Add(this.UnitPanel);
            this.panelControlGenneral.Controls.Add(this.InformPanel);
            this.panelControlGenneral.Controls.Add(this.label2);
            this.panelControlGenneral.Controls.Add(this.DoneBtn);
            this.panelControlGenneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlGenneral.Location = new System.Drawing.Point(0, 0);
            this.panelControlGenneral.Name = "panelControlGenneral";
            this.panelControlGenneral.Size = new System.Drawing.Size(908, 524);
            this.panelControlGenneral.TabIndex = 6;
            // 
            // DoingThings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 524);
            this.Controls.Add(this.panelControlGenneral);
            this.Name = "DoingThings";
            this.Text = "Add new Record";
            //((System.ComponentModel.ISupportInitialize)(this.UnitPanel)).EndInit();
            this.UnitPanel.ResumeLayout(false);
            this.UnitPanel.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.InformPanel)).EndInit();
            this.InformPanel.ResumeLayout(false);
            this.InformPanel.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.StatPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlGenneral)).EndInit();
            this.panelControlGenneral.ResumeLayout(false);
            this.panelControlGenneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UnitPanel;
        private DevExpress.XtraEditors.SimpleButton DoneBtn;
        private System.Windows.Forms.Panel InformPanel;
        private DevExpress.XtraEditors.LabelControl NameLbl;
        private DevExpress.XtraEditors.LabelControl label1;
        private System.Windows.Forms.ComboBox NameCbBox;
        private System.Windows.Forms.ComboBox TypeCbBox;
        private DevExpress.XtraEditors.LabelControl Goal_DeadlineLbl;
        private DevExpress.XtraEditors.LabelControl CurrentLbl;
        private System.Windows.Forms.Panel StatPanel;
        private DevExpress.XtraEditors.LabelControl ValueGoal_DeadlineLbl;
        private DevExpress.XtraEditors.LabelControl ValueCurrentBtn;
        private DevExpress.XtraEditors.LabelControl UnitLbl;
        private System.Windows.Forms.TextBox CurrentTxtBox;
        private System.Windows.Forms.CheckBox HasPlanChkBox;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.PanelControl panelControlGenneral;
    }
}