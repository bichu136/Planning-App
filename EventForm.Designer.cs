namespace Do_An
{
    partial class EventForm
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
            this.Onwaiting_Label = new System.Windows.Forms.Label();
            this.Ongoing_Label = new System.Windows.Forms.Label();
            this.Onwaiting_Panel = new System.Windows.Forms.Panel();
            this.Ongoing_Panel = new System.Windows.Forms.Panel();
            this.Passed_Label = new System.Windows.Forms.Label();
            this.Passed_Panel = new System.Windows.Forms.Panel();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Onwaiting_Label
            // 
            this.Onwaiting_Label.AutoSize = true;
            this.Onwaiting_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Onwaiting_Label.Location = new System.Drawing.Point(101, 34);
            this.Onwaiting_Label.Name = "Onwaiting_Label";
            this.Onwaiting_Label.Size = new System.Drawing.Size(205, 29);
            this.Onwaiting_Label.TabIndex = 0;
            this.Onwaiting_Label.Text = "On-waiting Event";
            // 
            // Ongoing_Label
            // 
            this.Ongoing_Label.AutoSize = true;
            this.Ongoing_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ongoing_Label.Location = new System.Drawing.Point(505, 34);
            this.Ongoing_Label.Name = "Ongoing_Label";
            this.Ongoing_Label.Size = new System.Drawing.Size(180, 29);
            this.Ongoing_Label.TabIndex = 1;
            this.Ongoing_Label.Text = "Ongoing Event";
            // 
            // Onwaiting_Panel
            // 
            this.Onwaiting_Panel.Location = new System.Drawing.Point(51, 76);
            this.Onwaiting_Panel.Name = "Onwaiting_Panel";
            this.Onwaiting_Panel.Size = new System.Drawing.Size(318, 174);
            this.Onwaiting_Panel.TabIndex = 2;
            // 
            // Ongoing_Panel
            // 
            this.Ongoing_Panel.Location = new System.Drawing.Point(413, 76);
            this.Ongoing_Panel.Name = "Ongoing_Panel";
            this.Ongoing_Panel.Size = new System.Drawing.Size(318, 174);
            this.Ongoing_Panel.TabIndex = 3;
            this.Ongoing_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Ongoing_Panel_Paint);
            // 
            // Passed_Label
            // 
            this.Passed_Label.AutoSize = true;
            this.Passed_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passed_Label.Location = new System.Drawing.Point(46, 272);
            this.Passed_Label.Name = "Passed_Label";
            this.Passed_Label.Size = new System.Drawing.Size(170, 29);
            this.Passed_Label.TabIndex = 4;
            this.Passed_Label.Text = "Passed Event";
            // 
            // Passed_Panel
            // 
            this.Passed_Panel.Location = new System.Drawing.Point(51, 315);
            this.Passed_Panel.Name = "Passed_Panel";
            this.Passed_Panel.Size = new System.Drawing.Size(541, 100);
            this.Passed_Panel.TabIndex = 5;
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.Location = new System.Drawing.Point(615, 324);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(116, 34);
            this.Add_Button.TabIndex = 6;
            this.Add_Button.Text = "Add Event";
            this.Add_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.Location = new System.Drawing.Point(615, 381);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(116, 34);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Passed_Panel);
            this.Controls.Add(this.Passed_Label);
            this.Controls.Add(this.Ongoing_Panel);
            this.Controls.Add(this.Onwaiting_Panel);
            this.Controls.Add(this.Ongoing_Label);
            this.Controls.Add(this.Onwaiting_Label);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Onwaiting_Label;
        private System.Windows.Forms.Label Ongoing_Label;
        private System.Windows.Forms.Panel Onwaiting_Panel;
        private System.Windows.Forms.Panel Ongoing_Panel;
        private System.Windows.Forms.Label Passed_Label;
        private System.Windows.Forms.Panel Passed_Panel;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Cancel_Button;
    }
}