namespace Do_An
{
    partial class DailyForm
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
            this.Daily_Label = new System.Windows.Forms.Label();
            this.Additional_Label = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.DailyDataGrid = new System.Windows.Forms.DataGridView();
            this.Additionnal_Panel = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).BeginInit();
            this.Additionnal_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Daily_Label
            // 
            this.Daily_Label.AutoSize = true;
            this.Daily_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daily_Label.Location = new System.Drawing.Point(133, 36);
            this.Daily_Label.Name = "Daily_Label";
            this.Daily_Label.Size = new System.Drawing.Size(145, 29);
            this.Daily_Label.TabIndex = 0;
            this.Daily_Label.Text = "Daily Tasks";
            // 
            // Additional_Label
            // 
            this.Additional_Label.AutoSize = true;
            this.Additional_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Additional_Label.Location = new System.Drawing.Point(476, 48);
            this.Additional_Label.Name = "Additional_Label";
            this.Additional_Label.Size = new System.Drawing.Size(200, 29);
            this.Additional_Label.TabIndex = 1;
            this.Additional_Label.Text = "Additional Tasks";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.Location = new System.Drawing.Point(85, 387);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 32);
            this.Cancel_Button.TabIndex = 4;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.Location = new System.Drawing.Point(266, 387);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 32);
            this.Update_button.TabIndex = 5;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // DailyDataGrid
            // 
            this.DailyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DailyDataGrid.Location = new System.Drawing.Point(85, 85);
            this.DailyDataGrid.Name = "DailyDataGrid";
            this.DailyDataGrid.RowHeadersWidth = 51;
            this.DailyDataGrid.RowTemplate.Height = 24;
            this.DailyDataGrid.Size = new System.Drawing.Size(256, 270);
            this.DailyDataGrid.TabIndex = 6;
            // 
            // Additionnal_Panel
            // 
            this.Additionnal_Panel.Controls.Add(this.vScrollBar1);
            this.Additionnal_Panel.Location = new System.Drawing.Point(431, 85);
            this.Additionnal_Panel.Name = "Additionnal_Panel";
            this.Additionnal_Panel.Size = new System.Drawing.Size(282, 270);
            this.Additionnal_Panel.TabIndex = 3;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(250, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 100);
            this.vScrollBar1.TabIndex = 0;
            // 
            // DailyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 496);
            this.Controls.Add(this.DailyDataGrid);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Additionnal_Panel);
            this.Controls.Add(this.Additional_Label);
            this.Controls.Add(this.Daily_Label);
            this.Name = "DailyForm";
            this.Text = "DailyForm";
            this.Load += new System.EventHandler(this.DailyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DailyDataGrid)).EndInit();
            this.Additionnal_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Daily_Label;
        private System.Windows.Forms.Label Additional_Label;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.DataGridView DailyDataGrid;
        private System.Windows.Forms.Panel Additionnal_Panel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}