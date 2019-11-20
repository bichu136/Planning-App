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
    public partial class ThingsToDoComponent : UserControl
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
                ConditionLbl.Text = TimeConditions.Days.ToString() + "Ngày " + TimeConditions.Hours.ToString() + "Giờ";
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
            this.ConditionLbl.Text = TimeConditions.Days.ToString() + "Ngày ";
            this.BackColor = getBackGroundColor();
        }

        private Color getBackGroundColor()
        {
            switch(Status)
            {
                case (int)ThingsToDo.statuses.Ongoing:
                    return Color.Yellow;
                case (int)ThingsToDo.statuses.Done:
                    return Color.Green;
                case (int)ThingsToDo.statuses.Dropped:
                    return Color.DarkGray;
                case (int)ThingsToDo.statuses.Waiting:
                    return Color.LightGray;
                case (int)ThingsToDo.statuses.Missed:
                    return Color.Red;
                default:
                    return Color.White;
            }
        }
    }
}
