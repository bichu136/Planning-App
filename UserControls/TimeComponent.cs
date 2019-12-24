using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Do_An
{
    public partial class TimeComponent : DevExpress.XtraEditors.XtraUserControl
    {
        Timer timer;
        public int result;
        TimeSpan Clock;
        public TimeComponent()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            
            InitializeComponent();
            SecLbl.Text = "00";
            MinLbl.Text = "00";
            HourLbl.Text = "00";
            Clock = TimeSpan.Zero;
            ToggleBtn.Text = "Start";
            ToggleBtn.Click += BeginTimer_Click;

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Clock = Clock.Add(TimeSpan.FromTicks(TimeSpan.TicksPerSecond));
            UpdateLabels(Clock);
        }

        private void BeginTimer_Click(object sender, EventArgs e)
        {
                timer.Start();
                SimpleButton x = (SimpleButton)sender;
                x.Click -= BeginTimer_Click;
                x.Click += EndTimer_Click;
                x.Text = "Pause";
        }

        private void UpdateLabels(TimeSpan clock)
        {
            SecLbl.Text = (clock.TotalSeconds - (int)clock.TotalMinutes * 60).ToString();
            MinLbl.Text = ((int)clock.TotalMinutes - (int)clock.TotalHours * 60).ToString();
            HourLbl.Text = ((int)clock.TotalHours).ToString();
        }

        private void EndTimer_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SimpleButton x = (SimpleButton)sender;
            x.Click += BeginTimer_Click;
            x.Click -= EndTimer_Click;
            x.Text = "Resume";
        }
    }
}
