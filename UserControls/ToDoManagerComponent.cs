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
    public partial class ToDoManagerComponent : UserControl
    {
        DailyData Ddata = new DailyData();
        ProjectData Pdata = new ProjectData();
        EventData Edata = new EventData();
        public ToDoManagerComponent()
        {
            InitializeComponent();

            //AddJobsBtn.Click += AddJobs_Click;
            DataGridViewComboBoxColumn checkboxes = new DataGridViewComboBoxColumn() { Name = "DONE", HeaderText = "Check", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells };
            StatusData Status = new StatusData();
            checkboxes.DataSource = Status.ReadDataTableForDaily();
            checkboxes.DisplayMember = "Name";
            checkboxes.ValueMember = "ID";
            DailyDataGrid.Columns.Add(checkboxes);

        }


        private void UpdateDailyBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DailyDataGrid.Rows)
            {
                Ddata.UpdateStatusByID(row.Cells["ID"].Value.ToString(), (long)row.Cells["DONE"].Value);
            }
        }

        private void ShowDeadlinesBtn_Click(object sender, EventArgs e)
        {
            DeadlineForm dlForm = new DeadlineForm();
            dlForm.ShowDialog();
        }

        private void ShowEventsBtn_Click(object sender, EventArgs e)
        {
            EventForm evForm = new EventForm();
            evForm.ShowDialog();
        }

        private void ToDoManagerComponent_Load(object sender, EventArgs e)
        {
            //DeadlineLabel Update.
            DeadlineLabel.Text = Pdata.getNearestDeadline();
            //EventLabel Update.
            label2.Text = Edata.getNextEvent();
            //DailyDatGrid Update.
            DailyDataGrid.DataSource = Ddata.ReadDataTable();
            DailyDataGrid.Columns["ID"].Visible = false;
            DailyDataGrid.Columns["Name1"].Visible = false;
            DailyDataGrid.Columns["Status"].Visible = false;
            foreach (DataGridViewRow Row in DailyDataGrid.Rows)
            {
                Row.Cells["DONE"].Value = (long)Row.Cells["Status"].Value;
            }
        }
    }
}
