using System.Windows.Forms;

namespace Do_An
{
    partial class AddThingToDoForm
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
            this.TypeCbBox = new System.Windows.Forms.ComboBox();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.Stat = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.StatsCbBox = new System.Windows.Forms.ComboBox();
            this.NewStatBtn = new System.Windows.Forms.Button();
            this.ScoreTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Ex1Lbl = new System.Windows.Forms.Label();
            this.Ex1TxtBox = new System.Windows.Forms.TextBox();
            this.Ex2Lbl = new System.Windows.Forms.Label();
            this.Ex2TxtBox = new System.Windows.Forms.TextBox();
            this.Ex1DateTime = new System.Windows.Forms.DateTimePicker();
            this.Ex2DateTime = new System.Windows.Forms.DateTimePicker();
            this.Ex1CbBox = new System.Windows.Forms.ComboBox();
            this.Ex1ChkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TypeCbBox
            // 
            this.TypeCbBox.FormattingEnabled = true;
            this.TypeCbBox.Location = new System.Drawing.Point(81, 170);
            this.TypeCbBox.Name = "TypeCbBox";
            this.TypeCbBox.Size = new System.Drawing.Size(241, 24);
            this.TypeCbBox.TabIndex = 0;
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(18, 173);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(40, 17);
            this.TypeLbl.TabIndex = 1;
            this.TypeLbl.Text = "Type";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(13, 18);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(45, 17);
            this.NameLbl.TabIndex = 3;
            this.NameLbl.Text = "Name";
            // 
            // Stat
            // 
            this.Stat.AutoSize = true;
            this.Stat.Location = new System.Drawing.Point(495, 18);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(33, 17);
            this.Stat.TabIndex = 4;
            this.Stat.Text = "Stat";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(64, 15);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(399, 22);
            this.NameTxtBox.TabIndex = 5;
            // 
            // StatsCbBox
            // 
            this.StatsCbBox.FormattingEnabled = true;
            this.StatsCbBox.Location = new System.Drawing.Point(583, 15);
            this.StatsCbBox.Name = "StatsCbBox";
            this.StatsCbBox.Size = new System.Drawing.Size(247, 24);
            this.StatsCbBox.TabIndex = 6;
            // 
            // NewStatBtn
            // 
            this.NewStatBtn.Location = new System.Drawing.Point(583, 45);
            this.NewStatBtn.Name = "NewStatBtn";
            this.NewStatBtn.Size = new System.Drawing.Size(247, 30);
            this.NewStatBtn.TabIndex = 7;
            this.NewStatBtn.Text = "New Stat";
            this.NewStatBtn.UseVisualStyleBackColor = true;
            // 
            // ScoreTxtBox
            // 
            this.ScoreTxtBox.Location = new System.Drawing.Point(583, 81);
            this.ScoreTxtBox.Name = "ScoreTxtBox";
            this.ScoreTxtBox.Size = new System.Drawing.Size(247, 22);
            this.ScoreTxtBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Stat\'s Score";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(702, 171);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(133, 54);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // Ex1Lbl
            // 
            this.Ex1Lbl.Location = new System.Drawing.Point(21, 56);
            this.Ex1Lbl.Name = "Ex1Lbl";
            this.Ex1Lbl.Size = new System.Drawing.Size(120, 19);
            this.Ex1Lbl.TabIndex = 10;
            this.Ex1Lbl.Text = "label2";
            this.Ex1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ex1TxtBox
            // 
            this.Ex1TxtBox.Location = new System.Drawing.Point(159, 53);
            this.Ex1TxtBox.Name = "Ex1TxtBox";
            this.Ex1TxtBox.Size = new System.Drawing.Size(100, 22);
            this.Ex1TxtBox.TabIndex = 11;
            // 
            // Ex2Lbl
            // 
            this.Ex2Lbl.Location = new System.Drawing.Point(43, 89);
            this.Ex2Lbl.Name = "Ex2Lbl";
            this.Ex2Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Ex2Lbl.Size = new System.Drawing.Size(98, 19);
            this.Ex2Lbl.TabIndex = 10;
            this.Ex2Lbl.Text = "label2";
            this.Ex2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ex2TxtBox
            // 
            this.Ex2TxtBox.Location = new System.Drawing.Point(159, 88);
            this.Ex2TxtBox.Name = "Ex2TxtBox";
            this.Ex2TxtBox.Size = new System.Drawing.Size(114, 22);
            this.Ex2TxtBox.TabIndex = 11;
            // 
            // Ex1DateTime
            // 
            this.Ex1DateTime.Location = new System.Drawing.Point(159, 53);
            this.Ex1DateTime.Name = "Ex1DateTime";
            this.Ex1DateTime.Size = new System.Drawing.Size(293, 22);
            this.Ex1DateTime.TabIndex = 12;
            // 
            // Ex2DateTime
            // 
            this.Ex2DateTime.Location = new System.Drawing.Point(159, 142);
            this.Ex2DateTime.Name = "Ex2DateTime";
            this.Ex2DateTime.Size = new System.Drawing.Size(293, 22);
            this.Ex2DateTime.TabIndex = 12;
            // 
            // Ex1CbBox
            // 
            this.Ex1CbBox.FormattingEnabled = true;
            this.Ex1CbBox.Location = new System.Drawing.Point(319, 112);
            this.Ex1CbBox.Name = "Ex1CbBox";
            this.Ex1CbBox.Size = new System.Drawing.Size(121, 24);
            this.Ex1CbBox.TabIndex = 13;
            // 
            // Ex1ChkBox
            // 
            this.Ex1ChkBox.AutoSize = true;
            this.Ex1ChkBox.Location = new System.Drawing.Point(98, 90);
            this.Ex1ChkBox.Name = "Ex1ChkBox";
            this.Ex1ChkBox.Size = new System.Drawing.Size(109, 21);
            this.Ex1ChkBox.TabIndex = 14;
            this.Ex1ChkBox.Text = "Có kế hoạch";
            this.Ex1ChkBox.UseVisualStyleBackColor = true;
            // 
            // AddThingToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 237);
            this.Controls.Add(this.Ex1ChkBox);
            this.Controls.Add(this.Ex1CbBox);
            this.Controls.Add(this.Ex2DateTime);
            this.Controls.Add(this.Ex1DateTime);
            this.Controls.Add(this.Ex2TxtBox);
            this.Controls.Add(this.Ex1TxtBox);
            this.Controls.Add(this.Ex2Lbl);
            this.Controls.Add(this.Ex1Lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreTxtBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.NewStatBtn);
            this.Controls.Add(this.StatsCbBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.Stat);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.TypeCbBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddThingToDoForm";
            this.Text = "AddThingToDoForm";
            this.Load += new System.EventHandler(this.AddThingToDoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AddThingToDoForm_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        private System.Windows.Forms.ComboBox TypeCbBox;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label Stat;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.ComboBox StatsCbBox;
        private System.Windows.Forms.Button NewStatBtn;
        private System.Windows.Forms.TextBox ScoreTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label Ex1Lbl;
        private System.Windows.Forms.TextBox Ex1TxtBox;
        private System.Windows.Forms.Label Ex2Lbl;
        private System.Windows.Forms.TextBox Ex2TxtBox;
        private System.Windows.Forms.DateTimePicker Ex1DateTime;
        private System.Windows.Forms.DateTimePicker Ex2DateTime;
        private ComboBox Ex1CbBox;
        private CheckBox Ex1ChkBox;

        public ComboBox TypeCbBox1 { get => TypeCbBox; set => TypeCbBox = value; }
        public Label TypeLbl1 { get => TypeLbl; set => TypeLbl = value; }
        public Label NameLbl1 { get => NameLbl; set => NameLbl = value; }
        public Label Stat1 { get => Stat; set => Stat = value; }
        public TextBox NameTxtBox1 { get => NameTxtBox; set => NameTxtBox = value; }
        public ComboBox StatsCbBox1 { get => StatsCbBox; set => StatsCbBox = value; }
        public Button NewStatBtn1 { get => NewStatBtn; set => NewStatBtn = value; }
        public TextBox ScoreTxtBox1 { get => ScoreTxtBox; set => ScoreTxtBox = value; }
        public TextBox ScoreTxtBox2 { get => ScoreTxtBox; set => ScoreTxtBox = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button AddBtn1 { get => AddBtn; set => AddBtn = value; }
        public Label Ex1Lbl1 { get => Ex1Lbl; set => Ex1Lbl = value; }
        public TextBox Ex1TxtBox1 { get => Ex1TxtBox; set => Ex1TxtBox = value; }
        public Label Ex2Lbl1 { get => Ex2Lbl; set => Ex2Lbl = value; }
        public TextBox Ex2TxtBox1 { get => Ex2TxtBox; set => Ex2TxtBox = value; }
        public DateTimePicker Ex1DateTime1 { get => Ex1DateTime; set => Ex1DateTime = value; }
        public DateTimePicker Ex2DateTime1 { get => Ex2DateTime; set => Ex2DateTime = value; }
    }
}