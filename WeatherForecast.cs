using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Do_An
{
    public partial class WeatherForecast : UserControl
    {
        Weather weather;
        private static WeatherForecast weatherforecast;
        public static WeatherForecast weatherForecast
        {
            get
            {
                if (weatherforecast == null) weatherforecast = new WeatherForecast();
                        return weatherforecast;
            }
        }
        public WeatherForecast()
        {
            InitializeComponent();
            weather = new Weather();
            this.WeatherForecast_Load();
        }

        public void WeatherForecast_Load()
        {
            //Weather Update.
            if (Program.ThoiTiet != "")
            {
                try
                {
                    weather.getData(Program.ThoiTiet);
                    WTimeLabel.Text = weather.Days[0].ToString();
                    WTenpfLbl.Text = weather.TempF[0];
                    WsymbLbl.Text = weather.Weathers[0];
                    WAreaLbl.Text = File.ReadAllText("ThoiTiet.txt");
                }

                catch (Exception ex)
                {

                }
            }
        }

    }
}
