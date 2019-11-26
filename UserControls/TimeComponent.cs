using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An
{
    public partial class TimeComponent : UserControl
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

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Clock.Add(TimeSpan.FromTicks(TimeSpan.TicksPerSecond));
            UpdateLabels(Clock);
        }

        private void BeginTimer_Click(object sender, EventArgs e)
        {
                timer.Start();
                Button x = (Button)sender;
                x.Click -= BeginTimer_Click;
                x.Click += EndTimer_Click;
                x.Text = "Pause";
        }

        private void UpdateLabels(TimeSpan clock)
        {
            SecLbl.Text = (clock.TotalSeconds - clock.TotalMinutes * 60).ToString().PadRight(2,'0');
            MinLbl.Text = (clock.TotalMinutes - clock.TotalHours * 60).ToString().PadRight(2, '0');
            HourLbl.Text = (clock.TotalHours).ToString().PadRight(2, '0');
        }

        private void EndTimer_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Button x = (Button)sender;
            x.Click += BeginTimer_Click;
            x.Click -= EndTimer_Click;
            x.Text = "Resume";
        }
    }
}
