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
    public partial class DeadlineForm : DevExpress.XtraEditors.XtraForm
    {
        int PanelOngoingOffset_X = 3;
        int PanelOngoingOffset_Y = 5;
        List<ThingsToDoComponent> Onwaiting;
        List<ThingsToDoComponent> Passed;
        public DeadlineForm()
        {
            Onwaiting = new List<ThingsToDoComponent>();
            Passed = new List<ThingsToDoComponent>();
            InitializeComponent();
            String Name;
            int Status;
            DateTime Deadline;

            Onwaiting.Clear();
            Passed.Clear();
            ProjectData data = new ProjectData();
            DataTable dt = data.Read_OnGoingDataTable();

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                Name = dt.Rows[i].Field<String>("Name");
                Status = Convert.ToInt32(dt.Rows[i].Field<long>("Status"));
                Deadline = Convert.ToDateTime(dt.Rows[i].Field<String>("Deadline"));
                switch (Status)
                {
                    case (int)ThingsToDo.statuses.Ongoing:
                    case (int)ThingsToDo.statuses.Dropped:
                        Onwaiting.Add(new ThingsToDoComponent(Name, Status, (Deadline - DateTime.Now)) { Location = new Point(PanelOngoingOffset_X, Onwaiting.Count * 53 + PanelOngoingOffset_Y) });
                        break;
                    default:
                        Passed.Add(new ThingsToDoComponent(Name, Status, (Deadline - DateTime.Now)) { Location = new Point(PanelOngoingOffset_X, Passed.Count * 53 + PanelOngoingOffset_Y) });
                        break;
                }
                //deadlinesToolStripMenuItem_Click(sender, e);
            }
        }

        private void DeadlineForm_Load(object sender, EventArgs e)
        {
            deadlinesToolStripMenuItem.BackColor = Color.FromArgb(124, 124, 124); //darkgray
            Onwaiting_Panel.Controls.Clear();
            Onwaiting_Panel.Controls.AddRange(Onwaiting.ToArray());
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deadlinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in menuStrip1.Items)
            {
                ToolStripMenuItem t = (ToolStripMenuItem)item;
                t.BackColor = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinMaskColor;
            }
            ToolStripMenuItem Input = (ToolStripMenuItem)sender;
            Input.BackColor = Color.FromArgb(124, 124, 124); //darkgray
            Onwaiting_Panel.Controls.Clear();
            Onwaiting_Panel.Controls.AddRange(Onwaiting.ToArray());
        }

        private void expiredDeadlinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item in menuStrip1.Items)
            {
                ToolStripMenuItem t = (ToolStripMenuItem)item;
                t.BackColor = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinMaskColor;
            }
            ToolStripMenuItem Input = (ToolStripMenuItem)sender;
            Input.BackColor = Color.FromArgb(124, 124, 124); //darkgray
            Onwaiting_Panel.Controls.Clear();
            Onwaiting_Panel.Controls.AddRange(Passed.ToArray());
        }
    }
}
