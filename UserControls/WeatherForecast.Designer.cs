namespace Do_An
{
    partial class WeatherForecast
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
            this.WAreaLbl = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.WsymbLbl = new System.Windows.Forms.Label();
            this.WTenpfLbl = new System.Windows.Forms.Label();
            this.WTimeLabel = new System.Windows.Forms.Label();
            this.labelWeather = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WAreaLbl
            // 
            this.WAreaLbl.AutoSize = true;
            this.WAreaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WAreaLbl.Location = new System.Drawing.Point(749, 289);
            this.WAreaLbl.Name = "WAreaLbl";
            this.WAreaLbl.Size = new System.Drawing.Size(99, 39);
            this.WAreaLbl.TabIndex = 7;
            this.WAreaLbl.Text = "None";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(561, 289);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(158, 39);
            this.labelArea.TabIndex = 6;
            this.labelArea.Text = "Khu vực: ";
            // 
            // WsymbLbl
            // 
            this.WsymbLbl.AutoSize = true;
            this.WsymbLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WsymbLbl.Location = new System.Drawing.Point(749, 84);
            this.WsymbLbl.Name = "WsymbLbl";
            this.WsymbLbl.Size = new System.Drawing.Size(99, 39);
            this.WsymbLbl.TabIndex = 5;
            this.WsymbLbl.Text = "None";
            // 
            // WTenpfLbl
            // 
            this.WTenpfLbl.AutoSize = true;
            this.WTenpfLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WTenpfLbl.Location = new System.Drawing.Point(268, 289);
            this.WTenpfLbl.Name = "WTenpfLbl";
            this.WTenpfLbl.Size = new System.Drawing.Size(99, 39);
            this.WTenpfLbl.TabIndex = 4;
            this.WTenpfLbl.Text = "None";
            // 
            // WTimeLabel
            // 
            this.WTimeLabel.AutoSize = true;
            this.WTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WTimeLabel.Location = new System.Drawing.Point(207, 84);
            this.WTimeLabel.Name = "WTimeLabel";
            this.WTimeLabel.Size = new System.Drawing.Size(99, 39);
            this.WTimeLabel.TabIndex = 3;
            this.WTimeLabel.Text = "None";
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeather.Location = new System.Drawing.Point(561, 84);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(159, 39);
            this.labelWeather.TabIndex = 2;
            this.labelWeather.Text = "Thời Tiết:";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.Location = new System.Drawing.Point(78, 289);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(153, 39);
            this.labelTemperature.TabIndex = 1;
            this.labelTemperature.Text = "Nhiệt độ:";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(78, 84);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(106, 39);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "Ngày:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1011, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 124);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // WeatherForecast
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WAreaLbl);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.WsymbLbl);
            this.Controls.Add(this.WTenpfLbl);
            this.Controls.Add(this.WTimeLabel);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelDay);
            this.Name = "WeatherForecast";
            this.Size = new System.Drawing.Size(1217, 567);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label labelWeather;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label WsymbLbl;
        private System.Windows.Forms.Label WTenpfLbl;
        private System.Windows.Forms.Label WTimeLabel;
        private System.Windows.Forms.Label WAreaLbl;
        private System.Windows.Forms.Label labelArea;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
