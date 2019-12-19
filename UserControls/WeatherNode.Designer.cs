namespace Do_An
{
    partial class WeatherNode
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WAreaLbl = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.WsymbLbl = new System.Windows.Forms.Label();
            this.WTenpfLbl = new System.Windows.Forms.Label();
            this.WTimeLabel = new System.Windows.Forms.Label();
            this.labelWeather = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(450, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 402);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // WAreaLbl
            // 
            this.WAreaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WAreaLbl.Location = new System.Drawing.Point(178, 129);
            this.WAreaLbl.Name = "WAreaLbl";
            this.WAreaLbl.Size = new System.Drawing.Size(179, 40);
            this.WAreaLbl.TabIndex = 17;
            this.WAreaLbl.Text = "None";
            // 
            // labelArea
            // 
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(19, 129);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(128, 40);
            this.labelArea.TabIndex = 16;
            this.labelArea.Text = "Khu vực: ";
            // 
            // WsymbLbl
            // 
            this.WsymbLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WsymbLbl.Location = new System.Drawing.Point(171, 437);
            this.WsymbLbl.Name = "WsymbLbl";
            this.WsymbLbl.Size = new System.Drawing.Size(186, 40);
            this.WsymbLbl.TabIndex = 15;
            this.WsymbLbl.Text = "None";
            // 
            // WTenpfLbl
            // 
            this.WTenpfLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WTenpfLbl.Location = new System.Drawing.Point(178, 278);
            this.WTenpfLbl.Name = "WTenpfLbl";
            this.WTenpfLbl.Size = new System.Drawing.Size(165, 40);
            this.WTenpfLbl.TabIndex = 14;
            this.WTenpfLbl.Text = "None";
            // 
            // WTimeLabel
            // 
            this.WTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WTimeLabel.Location = new System.Drawing.Point(178, 29);
            this.WTimeLabel.Name = "WTimeLabel";
            this.WTimeLabel.Size = new System.Drawing.Size(165, 40);
            this.WTimeLabel.TabIndex = 13;
            this.WTimeLabel.Text = "None";
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeather.Location = new System.Drawing.Point(19, 437);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(128, 31);
            this.labelWeather.TabIndex = 12;
            this.labelWeather.Text = "Thời Tiết:";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.Location = new System.Drawing.Point(19, 278);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(115, 31);
            this.labelTemperature.TabIndex = 11;
            this.labelTemperature.Text = "Nhiệt độ";
            // 
            // labelDay
            // 
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(19, 29);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(100, 40);
            this.labelDay.TabIndex = 10;
            this.labelDay.Text = "Ngày";
            // 
            // WeatherNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WAreaLbl);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.WsymbLbl);
            this.Controls.Add(this.WTenpfLbl);
            this.Controls.Add(this.WTimeLabel);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelDay);
            this.Name = "WeatherNode";
            this.Size = new System.Drawing.Size(987, 640);
            this.Load += new System.EventHandler(this.WeatherNode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WAreaLbl;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label WsymbLbl;
        private System.Windows.Forms.Label WTenpfLbl;
        private System.Windows.Forms.Label WTimeLabel;
        private System.Windows.Forms.Label labelWeather;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelDay;
    }
}
