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
    public partial class ThingsToDoComponent : DevExpress.XtraEditors.XtraUserControl
    {
        ThingsToDoData data;
        Timer UpdateTimeConditionsTimer;
        int Status;
        String Name;
        String GettedScore;
        TimeSpan TotalTimeConsumming;
        TimeSpan TimeConditions;
        public ThingsToDoComponent(String Name,int Status, TimeSpan TimeConditions)
        {
            UpdateTimeConditionsTimer = new Timer();
            InitializeComponent();
            UpdateTimeConditionsTimer.Interval = (int)TimeSpan.TicksPerMinute;
            UpdateTimeConditionsTimer.Tick += UpdateTimeConditionsTimer_Tick;

            this.Name = Name;
            this.Status = Status;
            this.TimeConditions = TimeConditions;
            UpdateTimeConditionsTimer.Start();
            this.Disposed += ThingsToDoComponent_Disposed;
        }
        String getStatusString()
        {
            ThingsToDo.statuses x = (ThingsToDo.statuses)Status;
            return x.ToString();
        }
        private void ThingsToDoComponent_Disposed(object sender, EventArgs e)
        {
            UpdateTimeConditionsTimer.Stop();
        }

        private void UpdateTimeConditionsTimer_Tick(object sender, EventArgs e)
        {            
            if(TimeConditions.Subtract(TimeSpan.FromTicks(TimeSpan.TicksPerMinute)) > TimeSpan.Zero)
            {
                ConditionLbl.Text = TimeConditions.Days.ToString() + " Ngày " + TimeConditions.Hours.ToString() + "Giờ";
            }
            this.ThingsToDoComponent_Load(sender, e);
        }

        private void ThingsToDoComponent_Load(object sender, EventArgs e)
        {
            Console.WriteLine(object.ReferenceEquals(sender, this.UpdateTimeConditionsTimer));
            if (object.ReferenceEquals(sender, this.UpdateTimeConditionsTimer))
            {
                this.Status = (int)ThingsToDo.statuses.Missed;
            }
            this.NameLbl.Text = Name;
            this.StatusLbl.Text = getStatusString();
            this.ConditionLbl.Text = TimeConditions.Days.ToString() + " Ngày ";
            this.BackColor = getBackGroundColor();
            this.NameLbl.ForeColor = IdealTextColor(BackColor);
            this.StatusLbl.ForeColor = IdealTextColor(BackColor);
            this.ConditionLbl.ForeColor = IdealTextColor(BackColor);
        }

        private Color IdealTextColor(Color bg)
        {
            int nThreshold = 105;
            int bgDelta = Convert.ToInt32((bg.R * 0.299) + (bg.G * 0.587) +
                                          (bg.B * 0.114));

            Color foreColor = (255 - bgDelta < nThreshold) ? Color.Black : Color.White;
            return foreColor;
        }
        private Color getBackGroundColor()
        {
            switch(Status)
            {
                case (int)ThingsToDo.statuses.Ongoing:
                    return Color.Yellow;//FromArgb(187,187,0);//YELLOW
                case (int)ThingsToDo.statuses.Done:
                    return Color.FromArgb(31,128,00); //GREEN
                case (int)ThingsToDo.statuses.Dropped:
                    return Color.Orange;
                case (int)ThingsToDo.statuses.Waiting:
                    return Color.LightSkyBlue;
                case (int)ThingsToDo.statuses.Missed:
                    return Color.Red;
                default:
                    return Color.White;
            }
        }
    }
}
