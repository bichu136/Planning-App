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
            this.Load += WeatherForecast_Load;


        }

        public void WeatherForecast_Load(object sender,EventArgs e)
        {
            if (Program.ThoiTiet != "")
            {
                try
                {
                    weather.getData(Program.ThoiTiet);
                    WTimeLabel.Text = weather.Days[0].ToString();
                    WTenpfLbl.Text = weather.TempF[0];
                    WsymbLbl.Text = weather.Weathers[0];
                    WAreaLbl.Text = File.ReadAllText("ThoiTiet.txt");
                    pictureBox1_Click(sender, e);
                }
                catch (Exception ex)
                {

                }
            }   

        }

        private void WeatherForecast_Load_1(object sender, EventArgs e)
        {

        }

        private void panelWeatherIcon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(weather.Type_weather[0]))
            {
                case 200:
                case 201:
                case 202:
                case 210:
                case 211:
                case 212:
                case 221:
                case 230:
                case 231:
                case 232:
                    pictureBox1.Image = Image.FromFile(@"resources//11d.png");
                    break;
                case 300:
                case 301:
                case 302:
                case 310:
                case 311:
                case 312:
                case 313:
                case 314:
                case 321:
                    pictureBox1.Image = Image.FromFile(@"resources//09d.png");
                    break;
                case 500:
                case 501:
                case 502:
                case 503:
                case 504:
                case 511:
                case 520:
                case 521:
                case 522:
                case 531:
                    pictureBox1.Image = Image.FromFile(@"resource//10d.png");
                    break;
                case 600:
                case 601:
                case 602:
                case 611:
                case 612:
                case 613:
                case 615:
                case 616:
                case 620:
                case 621:
                case 622:
                    pictureBox1.Image = Image.FromFile(@"resources//13d.png");
                    break;
                case 701:
                case 711:
                case 721:
                case 731:
                case 741:
                case 751:
                case 761:
                case 762:
                case 771:
                case 781:
                    pictureBox1.Image = Image.FromFile(@"resources//50d.png");
                    break;
                case 800:
                    pictureBox1.Image = Image.FromFile(@"resources//01d.png");
                    break;
                case 801:
                case 802:
                case 803:
                case 804:
                    pictureBox1.Image = Image.FromFile(@"resources//04d.png"); ;
                    break;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void labelDay_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void WeatherForecast_Load_2(object sender, EventArgs e)
        {

        }
    }
}



































































