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
    public partial class WeatherForecast : DevExpress.XtraEditors.XtraUserControl
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
                    //TODO: sửa các locations, xoá hết mấy cái kia đi
                    for (int i=0;i< weather.Days.Count ;i++)
                    {                      
                            WeatherNode t = new WeatherNode(weather, i) { Location = new Point(0, i*640) };
                            this.Controls.Add(t);
                            t.Visible = true;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void T_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CÓ node");
        }
    }
}



































































