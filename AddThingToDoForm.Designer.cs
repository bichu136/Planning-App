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
            this.IDLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.Stat = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.StatsCbBox = new System.Windows.Forms.ComboBox();
            this.NewStatBtn = new System.Windows.Forms.Button();
            this.ScoreTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TypeCbBox
            // 
            this.TypeCbBox.FormattingEnabled = true;
            this.TypeCbBox.Location = new System.Drawing.Point(58, 12);
            this.TypeCbBox.Name = "TypeCbBox";
            this.TypeCbBox.Size = new System.Drawing.Size(241, 24);
            this.TypeCbBox.TabIndex = 0;
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(12, 15);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(40, 17);
            this.TypeLbl.TabIndex = 1;
            this.TypeLbl.Text = "Type";
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(12, 86);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(21, 17);
            this.IDLbl.TabIndex = 2;
            this.IDLbl.Text = "ID";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(13, 132);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(45, 17);
            this.NameLbl.TabIndex = 3;
            this.NameLbl.Text = "Name";
            // 
            // Stat
            // 
            this.Stat.AutoSize = true;
            this.Stat.Location = new System.Drawing.Point(304, 86);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(33, 17);
            this.Stat.TabIndex = 4;
            this.Stat.Text = "Stat";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(65, 129);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(100, 22);
            this.NameTxtBox.TabIndex = 5;
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Location = new System.Drawing.Point(65, 83);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(100, 22);
            this.IDTxtBox.TabIndex = 5;
            // 
            // StatsCbBox
            // 
            this.StatsCbBox.FormattingEnabled = true;
            this.StatsCbBox.Location = new System.Drawing.Point(343, 83);
            this.StatsCbBox.Name = "StatsCbBox";
            this.StatsCbBox.Size = new System.Drawing.Size(155, 24);
            this.StatsCbBox.TabIndex = 6;
            // 
            // NewStatBtn
            // 
            this.NewStatBtn.Location = new System.Drawing.Point(361, 54);
            this.NewStatBtn.Name = "NewStatBtn";
            this.NewStatBtn.Size = new System.Drawing.Size(137, 23);
            this.NewStatBtn.TabIndex = 7;
            this.NewStatBtn.Text = "New Stat";
            this.NewStatBtn.UseVisualStyleBackColor = true;
            // 
            // ScoreTxtBox
            // 
            this.ScoreTxtBox.Location = new System.Drawing.Point(394, 120);
            this.ScoreTxtBox.Name = "ScoreTxtBox";
            this.ScoreTxtBox.Size = new System.Drawing.Size(104, 22);
            this.ScoreTxtBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Stat\'s Score";
            // 
            // AddThingToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreTxtBox);
            this.Controls.Add(this.NewStatBtn);
            this.Controls.Add(this.StatsCbBox);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.Stat);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.TypeCbBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddThingToDoForm";
            this.Text = "AddThingToDoForm";
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
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label Stat;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox IDTxtBox;
        private System.Windows.Forms.ComboBox StatsCbBox;
        private System.Windows.Forms.Button NewStatBtn;
        private System.Windows.Forms.TextBox ScoreTxtBox;
        private System.Windows.Forms.Label label1;
    }
}