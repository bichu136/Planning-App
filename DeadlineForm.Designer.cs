namespace Do_An
{
    partial class DeadlineForm
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
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Passed_Panel = new System.Windows.Forms.Panel();
            this.Passed_Label = new System.Windows.Forms.Label();
            this.Onwaiting_Panel = new System.Windows.Forms.Panel();
            this.Ongoing_Label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deadlinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expiredDeadlinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.Location = new System.Drawing.Point(234, 422);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(135, 51);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.Location = new System.Drawing.Point(45, 422);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(183, 51);
            this.Add_Button.TabIndex = 14;
            this.Add_Button.Text = "Add Deadlines";
            this.Add_Button.UseVisualStyleBackColor = true;
            // 
            // Passed_Panel
            // 
            this.Passed_Panel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Passed_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Passed_Panel.Location = new System.Drawing.Point(45, 316);
            this.Passed_Panel.Name = "Passed_Panel";
            this.Passed_Panel.Size = new System.Drawing.Size(680, 100);
            this.Passed_Panel.TabIndex = 13;
            // 
            // Passed_Label
            // 
            this.Passed_Label.AutoSize = true;
            this.Passed_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passed_Label.Location = new System.Drawing.Point(40, 273);
            this.Passed_Label.Name = "Passed_Label";
            this.Passed_Label.Size = new System.Drawing.Size(0, 29);
            this.Passed_Label.TabIndex = 12;
            // 
            // Onwaiting_Panel
            // 
            this.Onwaiting_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Onwaiting_Panel.Location = new System.Drawing.Point(45, 77);
            this.Onwaiting_Panel.Name = "Onwaiting_Panel";
            this.Onwaiting_Panel.Size = new System.Drawing.Size(680, 174);
            this.Onwaiting_Panel.TabIndex = 10;
            // 
            // Ongoing_Label
            // 
            this.Ongoing_Label.AutoSize = true;
            this.Ongoing_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ongoing_Label.Location = new System.Drawing.Point(380, 273);
            this.Ongoing_Label.Name = "Ongoing_Label";
            this.Ongoing_Label.Size = new System.Drawing.Size(0, 29);
            this.Ongoing_Label.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deadlinesToolStripMenuItem,
            this.expiredDeadlinesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deadlinesToolStripMenuItem
            // 
            this.deadlinesToolStripMenuItem.Name = "deadlinesToolStripMenuItem";
            this.deadlinesToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.deadlinesToolStripMenuItem.Text = "Deadlines";
            this.deadlinesToolStripMenuItem.Click += new System.EventHandler(this.deadlinesToolStripMenuItem_Click);
            // 
            // expiredDeadlinesToolStripMenuItem
            // 
            this.expiredDeadlinesToolStripMenuItem.Name = "expiredDeadlinesToolStripMenuItem";
            this.expiredDeadlinesToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.expiredDeadlinesToolStripMenuItem.Text = "Expired Deadlines";
            this.expiredDeadlinesToolStripMenuItem.Click += new System.EventHandler(this.expiredDeadlinesToolStripMenuItem_Click);
            // 
            // DeadlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 473);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Passed_Panel);
            this.Controls.Add(this.Passed_Label);
            this.Controls.Add(this.Onwaiting_Panel);
            this.Controls.Add(this.Ongoing_Label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DeadlineForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DeadlineForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Panel Passed_Panel;
        private System.Windows.Forms.Label Passed_Label;
        private System.Windows.Forms.Panel Onwaiting_Panel;
        private System.Windows.Forms.Label Ongoing_Label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deadlinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expiredDeadlinesToolStripMenuItem;
    }
}