namespace Do_An
{
    partial class TimeComponent
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
            this.UnitPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SecLbl = new System.Windows.Forms.Label();
            this.MinLbl = new System.Windows.Forms.Label();
            this.HourLbl = new System.Windows.Forms.Label();
            this.ToggleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.UnitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnitPanel
            // 
            this.UnitPanel.Controls.Add(this.label2);
            this.UnitPanel.Controls.Add(this.label1);
            this.UnitPanel.Controls.Add(this.SecLbl);
            this.UnitPanel.Controls.Add(this.MinLbl);
            this.UnitPanel.Controls.Add(this.HourLbl);
            this.UnitPanel.Controls.Add(this.ToggleBtn);
            this.UnitPanel.Location = new System.Drawing.Point(26, 23);
            this.UnitPanel.Name = "UnitPanel";
            this.UnitPanel.Size = new System.Drawing.Size(441, 108);
            this.UnitPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // SecLbl
            // 
            this.SecLbl.AutoSize = true;
            this.SecLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecLbl.Location = new System.Drawing.Point(258, 10);
            this.SecLbl.Name = "SecLbl";
            this.SecLbl.Size = new System.Drawing.Size(61, 38);
            this.SecLbl.TabIndex = 3;
            this.SecLbl.Text = "XX";
            // 
            // MinLbl
            // 
            this.MinLbl.AutoSize = true;
            this.MinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLbl.Location = new System.Drawing.Point(189, 10);
            this.MinLbl.Name = "MinLbl";
            this.MinLbl.Size = new System.Drawing.Size(61, 38);
            this.MinLbl.TabIndex = 3;
            this.MinLbl.Text = "XX";
            // 
            // HourLbl
            // 
            this.HourLbl.AutoSize = true;
            this.HourLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourLbl.Location = new System.Drawing.Point(120, 10);
            this.HourLbl.Name = "HourLbl";
            this.HourLbl.Size = new System.Drawing.Size(61, 38);
            this.HourLbl.TabIndex = 3;
            this.HourLbl.Text = "XX";
            // 
            // ToggleBtn
            // 
            this.ToggleBtn.Location = new System.Drawing.Point(160, 49);
            this.ToggleBtn.Name = "ToggleBtn";
            this.ToggleBtn.Size = new System.Drawing.Size(119, 51);
            this.ToggleBtn.TabIndex = 0;
            this.ToggleBtn.Text = "LockBtn";
            //this.ToggleBtn.UseVisualStyleBackColor = true;
            // 
            // TimeComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UnitPanel);
            this.Name = "TimeComponent";
            this.Size = new System.Drawing.Size(477, 147);
            this.UnitPanel.ResumeLayout(false);
            this.UnitPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UnitPanel;
        private System.Windows.Forms.Label HourLbl;
        private System.Windows.Forms.Label SecLbl;
        private System.Windows.Forms.Label MinLbl;
        private DevExpress.XtraEditors.SimpleButton ToggleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
