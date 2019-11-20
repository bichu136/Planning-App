using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An
{
    public partial class EventForm : Form
    {
        List<ThingsToDoComponent> Ongoing_Event;
        List<ThingsToDoComponent> OnWaiting_Event;
        List<ThingsToDoComponent> Passed_Event;
        EventData Edata = new EventData();
        DataTable dt;
        public EventForm()
        {
            
            Ongoing_Event = new List <ThingsToDoComponent>();
            OnWaiting_Event = new List<ThingsToDoComponent>();
            Passed_Event = new List<ThingsToDoComponent>();
            InitializeComponent();
            dt = Edata.ReadDataTable();
            int PanelOngoingOffset_X = 10;
            int PanelOngoingOffset_Y = 10;
            foreach (DataRow row in dt.Rows)
            {

                // Name,Status,date(TxtRow1) ShowTime
                String Name = row.Field<String>("Name");
                int Status = Convert.ToInt32(row.Field<long>("Status"));
                DateTime ShowTime = Convert.ToDateTime(row.Field<String>("ShowTime"));
                switch (Status)
                {
                    case (int)ThingsToDo.statuses.Ongoing:
                        Ongoing_Event.Add(new ThingsToDoComponent(Name, Status, (ShowTime - DateTime.Now)) { Location = new Point(PanelOngoingOffset_X, Ongoing_Event.Count * 53 + PanelOngoingOffset_Y) });
                        break;
                    case (int)ThingsToDo.statuses.Waiting:
                        break;
                    default:
                        Passed_Event.Add(new ThingsToDoComponent(Name, Status, (ShowTime - DateTime.Now)) { Location = new Point(PanelOngoingOffset_X, Passed_Event.Count * 53 + PanelOngoingOffset_Y) });
                        break;                    
                }
            }
            foreach (DataRow row in dt.Rows)
            {
                int Status = Convert.ToInt32(row.Field<long>("Status"));
                if (Status == (int)ThingsToDo.statuses.Waiting)
                {
                    String Name = row.Field<String>("Name");
                    DateTime ShowTime = Convert.ToDateTime(row.Field<String>("ShowTime"));
                    OnWaiting_Event.Add(new ThingsToDoComponent(Name, Status, (ShowTime - DateTime.Now)) { Location = new Point(PanelOngoingOffset_X, Ongoing_Event.Count * 53 + PanelOngoingOffset_Y + OnWaiting_Event.Count) });
                }
            }
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            Onwaiting_Panel.Controls.Clear();
            Onwaiting_Panel.Controls.AddRange(Ongoing_Event.ToArray());
            Onwaiting_Panel.Controls.AddRange(OnWaiting_Event.ToArray());
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onwaiting_Panel.Controls.Clear();
            Onwaiting_Panel.Controls.AddRange(Ongoing_Event.ToArray());
            Onwaiting_Panel.Controls.AddRange(OnWaiting_Event.ToArray());
        }

        private void passedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onwaiting_Panel.Controls.Clear();
            Onwaiting_Panel.Controls.AddRange(Passed_Event.ToArray());
        }
    }
}
