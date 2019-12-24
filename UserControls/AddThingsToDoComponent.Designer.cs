using System.Windows.Forms;

namespace Do_An
{
    partial class AddThingsToDoComponent
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
            this.Ex1ChkBox = new System.Windows.Forms.CheckBox();
            this.Ex1CbBox = new System.Windows.Forms.ComboBox();
            this.Ex2DateTime = new System.Windows.Forms.DateTimePicker();
            this.Ex1DateTime = new System.Windows.Forms.DateTimePicker();
            this.Ex2TxtBox = new System.Windows.Forms.TextBox();
            this.Ex1TxtBox = new System.Windows.Forms.TextBox();
            this.Ex2Lbl = new DevExpress.XtraEditors.LabelControl();
            this.Ex1Lbl = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.ScoreTxtBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.NewStatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.StatsCbBox = new System.Windows.Forms.ComboBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.Stat = new DevExpress.XtraEditors.LabelControl();
            this.NameLbl = new DevExpress.XtraEditors.LabelControl();
            this.TypeLbl = new DevExpress.XtraEditors.LabelControl();
            this.TypeCbBox = new System.Windows.Forms.ComboBox();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.panelGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ex1ChkBox
            // 
            this.Ex1ChkBox.AutoSize = true;
            this.Ex1ChkBox.Location = new System.Drawing.Point(507, 27);
            this.Ex1ChkBox.Name = "Ex1ChkBox";
            this.Ex1ChkBox.Size = new System.Drawing.Size(107, 21);
            this.Ex1ChkBox.TabIndex = 32;
            this.Ex1ChkBox.Text = "Có kế hoạch";
            this.Ex1ChkBox.UseVisualStyleBackColor = true;
            // 
            // Ex1CbBox
            // 
            this.Ex1CbBox.FormattingEnabled = true;
            this.Ex1CbBox.Location = new System.Drawing.Point(634, 67);
            this.Ex1CbBox.Name = "Ex1CbBox";
            this.Ex1CbBox.Size = new System.Drawing.Size(121, 24);
            this.Ex1CbBox.TabIndex = 31;
            // 
            // Ex2DateTime
            // 
            this.Ex2DateTime.Location = new System.Drawing.Point(634, 69);
            this.Ex2DateTime.Name = "Ex2DateTime";
            this.Ex2DateTime.Size = new System.Drawing.Size(293, 23);
            this.Ex2DateTime.TabIndex = 30;
            // 
            // Ex1DateTime
            // 
            this.Ex1DateTime.Location = new System.Drawing.Point(173, 66);
            this.Ex1DateTime.Name = "Ex1DateTime";
            this.Ex1DateTime.Size = new System.Drawing.Size(293, 23);
            this.Ex1DateTime.TabIndex = 29;
            // 
            // Ex2TxtBox
            // 
            this.Ex2TxtBox.Location = new System.Drawing.Point(634, 67);
            this.Ex2TxtBox.Name = "Ex2TxtBox";
            this.Ex2TxtBox.Size = new System.Drawing.Size(114, 23);
            this.Ex2TxtBox.TabIndex = 28;
            // 
            // Ex1TxtBox
            // 
            this.Ex1TxtBox.Location = new System.Drawing.Point(173, 66);
            this.Ex1TxtBox.Name = "Ex1TxtBox";
            this.Ex1TxtBox.Size = new System.Drawing.Size(100, 23);
            this.Ex1TxtBox.TabIndex = 27;
            // 
            // Ex2Lbl
            // 
            this.Ex2Lbl.Location = new System.Drawing.Point(518, 68);
            this.Ex2Lbl.Name = "Ex2Lbl";
            this.Ex2Lbl.Size = new System.Drawing.Size(34, 16);
            this.Ex2Lbl.TabIndex = 25;
            this.Ex2Lbl.Text = "label2";
            // 
            // Ex1Lbl
            // 
            this.Ex1Lbl.Location = new System.Drawing.Point(35, 69);
            this.Ex1Lbl.Name = "Ex1Lbl";
            this.Ex1Lbl.Size = new System.Drawing.Size(34, 16);
            this.Ex1Lbl.TabIndex = 26;
            this.Ex1Lbl.Text = "label2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Stat\'s Score";
            // 
            // ScoreTxtBox
            // 
            this.ScoreTxtBox.Location = new System.Drawing.Point(98, 253);
            this.ScoreTxtBox.Name = "ScoreTxtBox";
            this.ScoreTxtBox.Size = new System.Drawing.Size(247, 23);
            this.ScoreTxtBox.TabIndex = 23;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.AddBtn.Appearance.Options.UseFont = true;
            this.AddBtn.AutoSize = true;
            this.AddBtn.Location = new System.Drawing.Point(1069, 476);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(50, 35);
            this.AddBtn.TabIndex = 22;
            this.AddBtn.Text = "Add";
            // 
            // NewStatBtn
            // 
            this.NewStatBtn.Location = new System.Drawing.Point(98, 217);
            this.NewStatBtn.Name = "NewStatBtn";
            this.NewStatBtn.Size = new System.Drawing.Size(247, 30);
            this.NewStatBtn.TabIndex = 21;
            this.NewStatBtn.Text = "New Stat";
            // 
            // StatsCbBox
            // 
            this.StatsCbBox.FormattingEnabled = true;
            this.StatsCbBox.Location = new System.Drawing.Point(98, 187);
            this.StatsCbBox.Name = "StatsCbBox";
            this.StatsCbBox.Size = new System.Drawing.Size(247, 24);
            this.StatsCbBox.TabIndex = 20;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(78, 28);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(399, 23);
            this.NameTxtBox.TabIndex = 19;
            // 
            // Stat
            // 
            this.Stat.Location = new System.Drawing.Point(10, 190);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(23, 16);
            this.Stat.TabIndex = 18;
            this.Stat.Text = "Stat";
            // 
            // NameLbl
            // 
            this.NameLbl.Location = new System.Drawing.Point(27, 31);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(33, 16);
            this.NameLbl.TabIndex = 17;
            this.NameLbl.Text = "Name";
            // 
            // TypeLbl
            // 
            this.TypeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TypeLbl.Location = new System.Drawing.Point(26, 515);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(28, 16);
            this.TypeLbl.TabIndex = 16;
            this.TypeLbl.Text = "Type";
            // 
            // TypeCbBox
            // 
            this.TypeCbBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TypeCbBox.FormattingEnabled = true;
            this.TypeCbBox.Location = new System.Drawing.Point(89, 512);
            this.TypeCbBox.Name = "TypeCbBox";
            this.TypeCbBox.Size = new System.Drawing.Size(241, 24);
            this.TypeCbBox.TabIndex = 15;
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.Ex1ChkBox);
            this.panelGeneral.Controls.Add(this.Ex1CbBox);
            this.panelGeneral.Controls.Add(this.Ex2DateTime);
            this.panelGeneral.Controls.Add(this.Ex1DateTime);
            this.panelGeneral.Controls.Add(this.Ex2TxtBox);
            this.panelGeneral.Controls.Add(this.Ex1TxtBox);
            this.panelGeneral.Controls.Add(this.Ex2Lbl);
            this.panelGeneral.Controls.Add(this.Ex1Lbl);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Controls.Add(this.ScoreTxtBox);
            this.panelGeneral.Controls.Add(this.AddBtn);
            this.panelGeneral.Controls.Add(this.NewStatBtn);
            this.panelGeneral.Controls.Add(this.StatsCbBox);
            this.panelGeneral.Controls.Add(this.NameTxtBox);
            this.panelGeneral.Controls.Add(this.Stat);
            this.panelGeneral.Controls.Add(this.NameLbl);
            this.panelGeneral.Controls.Add(this.TypeLbl);
            this.panelGeneral.Controls.Add(this.TypeCbBox);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1217, 567);
            this.panelGeneral.TabIndex = 33;
            // 
            // AddThingsToDoComponent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelGeneral);
            this.Name = "AddThingsToDoComponent";
            this.Size = new System.Drawing.Size(1217, 567);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox Ex1ChkBox;
        private System.Windows.Forms.ComboBox Ex1CbBox;
        private System.Windows.Forms.DateTimePicker Ex2DateTime;
        private System.Windows.Forms.DateTimePicker Ex1DateTime;
        private System.Windows.Forms.TextBox Ex2TxtBox;
        private System.Windows.Forms.TextBox Ex1TxtBox;
        private DevExpress.XtraEditors.LabelControl Ex2Lbl;
        private DevExpress.XtraEditors.LabelControl Ex1Lbl;
        private DevExpress.XtraEditors.LabelControl label1;
        private System.Windows.Forms.TextBox ScoreTxtBox;
        private DevExpress.XtraEditors.SimpleButton AddBtn;
        private DevExpress.XtraEditors.SimpleButton NewStatBtn;
        private System.Windows.Forms.ComboBox StatsCbBox;
        private System.Windows.Forms.TextBox NameTxtBox;
        private DevExpress.XtraEditors.LabelControl Stat;
        private DevExpress.XtraEditors.LabelControl NameLbl;
        private DevExpress.XtraEditors.LabelControl TypeLbl;
        private System.Windows.Forms.ComboBox TypeCbBox;
        private System.Windows.Forms.Panel panelGeneral;

        public ComboBox statsCbBox { get => StatsCbBox; set => StatsCbBox = value; }
    }
}
