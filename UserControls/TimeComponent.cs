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
        private ThingsToDo args;
        public int result;
        public TimeComponent()
        {
            this.args = args;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            InitializeComponent();
            DoingTxtBox.KeyPress += Default.OnlyNumberPress;

        }
        public TimeComponent(ThingsToDo args)
        {
            this.args = args;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            
            InitializeComponent();
            DoingTxtBox.KeyPress += Default.OnlyNumberPress;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BeginTimer_Click(object sender, EventArgs e)
        {
                timer.Start();
                Button x = (Button)sender;
                x.Click += EndTimer_Click;
                x.Text = "Done";            
        }

        private void EndTimer_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void DoingTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
