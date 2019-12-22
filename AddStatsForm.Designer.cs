namespace Do_An
{
    partial class AddStatsForm
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
            this.addBtn = new DevExpress.XtraEditors.SimpleButton();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.DesTxtBox = new System.Windows.Forms.TextBox();
            this.Namelbl = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Deslbl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(396, 13);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 29);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(147, 19);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(213, 23);
            this.NameTxtBox.TabIndex = 1;
            // 
            // DesTxtBox
            // 
            this.DesTxtBox.Location = new System.Drawing.Point(12, 123);
            this.DesTxtBox.Multiline = true;
            this.DesTxtBox.Name = "DesTxtBox";
            this.DesTxtBox.Size = new System.Drawing.Size(478, 244);
            this.DesTxtBox.TabIndex = 2;
            // 
            // Namelbl
            // 
            this.Namelbl.Location = new System.Drawing.Point(35, 22);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(33, 16);
            this.Namelbl.TabIndex = 3;
            this.Namelbl.Text = "Name";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Deslbl);
            this.panelControl1.Controls.Add(this.Namelbl);
            this.panelControl1.Controls.Add(this.DesTxtBox);
            this.panelControl1.Controls.Add(this.NameTxtBox);
            this.panelControl1.Controls.Add(this.addBtn);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(502, 379);
            this.panelControl1.TabIndex = 4;
            // 
            // Deslbl
            // 
            this.Deslbl.Location = new System.Drawing.Point(35, 89);
            this.Deslbl.Name = "Deslbl";
            this.Deslbl.Size = new System.Drawing.Size(63, 16);
            this.Deslbl.TabIndex = 3;
            this.Deslbl.Text = "Description";
            // 
            // AddStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 379);
            this.Controls.Add(this.panelControl1);
            this.Name = "AddStatsForm";
            this.Text = "AddStatsForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton addBtn;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox DesTxtBox;
        private DevExpress.XtraEditors.LabelControl Namelbl;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl Deslbl;
    }
}