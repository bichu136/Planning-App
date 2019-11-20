namespace Do_An
{
    partial class ThingsToDoComponent
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.ConditionLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(19, 15);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(64, 17);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "NameLbl";
            // 
            // ConditionLbl
            // 
            this.ConditionLbl.AutoSize = true;
            this.ConditionLbl.Location = new System.Drawing.Point(285, 15);
            this.ConditionLbl.Name = "ConditionLbl";
            this.ConditionLbl.Size = new System.Drawing.Size(86, 17);
            this.ConditionLbl.TabIndex = 1;
            this.ConditionLbl.Text = "ConditionLbl";
            this.ConditionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(556, 15);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(46, 17);
            this.StatusLbl.TabIndex = 2;
            this.StatusLbl.Text = "status";
            this.StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ThingsToDoComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.ConditionLbl);
            this.Controls.Add(this.NameLbl);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "ThingsToDoComponent";
            this.Size = new System.Drawing.Size(630, 48);
            this.Load += new System.EventHandler(this.ThingsToDoComponent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label ConditionLbl;
        private System.Windows.Forms.Label StatusLbl;
    }
}
