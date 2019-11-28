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
            this.panelWeatherIcon = new System.Windows.Forms.Panel();
            this.WAreaLbl = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.WsymbLbl = new System.Windows.Forms.Label();
            this.WTenpfLbl = new System.Windows.Forms.Label();
            this.WTimeLabel = new System.Windows.Forms.Label();
            this.labelWeather = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelWeatherIcon
            // 
            this.panelWeatherIcon.Location = new System.Drawing.Point(234, 88);
            this.panelWeatherIcon.Name = "panelWeatherIcon";
            this.panelWeatherIcon.Size = new System.Drawing.Size(81, 71);
            this.panelWeatherIcon.TabIndex = 8;
            // 
            // WAreaLbl
            // 
            this.WAreaLbl.AutoSize = true;
            this.WAreaLbl.Location = new System.Drawing.Point(273, 15);
            this.WAreaLbl.Name = "WAreaLbl";
            this.WAreaLbl.Size = new System.Drawing.Size(42, 17);
            this.WAreaLbl.TabIndex = 7;
            this.WAreaLbl.Text = "None";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(200, 15);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(67, 17);
            this.labelArea.TabIndex = 6;
            this.labelArea.Text = "Khu vực: ";
            // 
            // WsymbLbl
            // 
            this.WsymbLbl.AutoSize = true;
            this.WsymbLbl.Location = new System.Drawing.Point(120, 142);
            this.WsymbLbl.Name = "WsymbLbl";
            this.WsymbLbl.Size = new System.Drawing.Size(42, 17);
            this.WsymbLbl.TabIndex = 5;
            this.WsymbLbl.Text = "None";
            // 
            // WTenpfLbl
            // 
            this.WTenpfLbl.AutoSize = true;
            this.WTenpfLbl.Location = new System.Drawing.Point(120, 75);
            this.WTenpfLbl.Name = "WTenpfLbl";
            this.WTenpfLbl.Size = new System.Drawing.Size(42, 17);
            this.WTenpfLbl.TabIndex = 4;
            this.WTenpfLbl.Text = "None";
            // 
            // WTimeLabel
            // 
            this.WTimeLabel.AutoSize = true;
            this.WTimeLabel.Location = new System.Drawing.Point(120, 15);
            this.WTimeLabel.Name = "WTimeLabel";
            this.WTimeLabel.Size = new System.Drawing.Size(42, 17);
            this.WTimeLabel.TabIndex = 3;
            this.WTimeLabel.Text = "None";
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Location = new System.Drawing.Point(11, 142);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(68, 17);
            this.labelWeather.TabIndex = 2;
            this.labelWeather.Text = "Thời Tiết:";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(11, 75);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(61, 17);
            this.labelTemperature.TabIndex = 1;
            this.labelTemperature.Text = "Nhiệt độ";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(18, 15);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(41, 17);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "Ngày";
            // 
            // WeatherForecast
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelWeatherIcon);
            this.Controls.Add(this.WAreaLbl);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.WsymbLbl);
            this.Controls.Add(this.WTenpfLbl);
            this.Controls.Add(this.WTimeLabel);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelDay);
            this.Name = "WeatherForecast";
            this.Size = new System.Drawing.Size(986, 565);
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
        private System.Windows.Forms.Panel panelWeatherIcon;

        #endregion
    }
}
