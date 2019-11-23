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
            this.CounterLbl = new System.Windows.Forms.Label();
            this.UnitLbl = new System.Windows.Forms.Label();
            this.DoingTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UnitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnitPanel
            // 
            this.UnitPanel.Controls.Add(this.CounterLbl);
            this.UnitPanel.Controls.Add(this.UnitLbl);
            this.UnitPanel.Controls.Add(this.DoingTxtBox);
            this.UnitPanel.Controls.Add(this.button1);
            this.UnitPanel.Location = new System.Drawing.Point(26, 23);
            this.UnitPanel.Name = "UnitPanel";
            this.UnitPanel.Size = new System.Drawing.Size(441, 108);
            this.UnitPanel.TabIndex = 1;
            // 
            // CounterLbl
            // 
            this.CounterLbl.AutoSize = true;
            this.CounterLbl.Location = new System.Drawing.Point(128, 66);
            this.CounterLbl.Name = "CounterLbl";
            this.CounterLbl.Size = new System.Drawing.Size(26, 17);
            this.CounterLbl.TabIndex = 3;
            this.CounterLbl.Text = "XX";
            // 
            // UnitLbl
            // 
            this.UnitLbl.AutoSize = true;
            this.UnitLbl.Location = new System.Drawing.Point(316, 19);
            this.UnitLbl.Name = "UnitLbl";
            this.UnitLbl.Size = new System.Drawing.Size(46, 17);
            this.UnitLbl.TabIndex = 2;
            this.UnitLbl.Text = "label2";
            // 
            // DoingTxtBox
            // 
            this.DoingTxtBox.Location = new System.Drawing.Point(210, 16);
            this.DoingTxtBox.Name = "DoingTxtBox";
            this.DoingTxtBox.Size = new System.Drawing.Size(100, 22);
            this.DoingTxtBox.TabIndex = 1;
            this.DoingTxtBox.TextChanged += new System.EventHandler(this.DoingTxtBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "LockBtn";
            this.button1.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Label CounterLbl;
        private System.Windows.Forms.Label UnitLbl;
        private System.Windows.Forms.TextBox DoingTxtBox;
        private System.Windows.Forms.Button button1;
    }
}
