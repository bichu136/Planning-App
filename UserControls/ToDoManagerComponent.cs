﻿using System;
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
    public partial class ToDoManagerComponent : DevExpress.XtraEditors.XtraUserControl
    {
        DailyData Ddata = new DailyData();
        ProjectData Pdata = new ProjectData();
        EventData Edata = new EventData();
        RecordData RData = new RecordData();
        public ToDoManagerComponent()
        {
            InitializeComponent();
            //AddJobsBtn.Click += AddJobs_Click;
        }


        private void UpdateDailyBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DailyDataGrid.Rows)
            {
                if ((long)row.Cells["DONE"].Value == 0)
                {
                    Ddata.UpdateStatusByID(row.Cells["ID"].Value.ToString(), (long)row.Cells["DONE"].Value);
                    RData.Insert(new Record(Convert.ToInt32(row.Cells["ID"].Value.ToString()), DateTime.Now, 0));
                }
            }
        }

        private void ShowDeadlinesBtn_Click(object sender, EventArgs e)
        {
            Ddata.UpdateDropStatus();
            DeadlineForm dlForm = new DeadlineForm();
            dlForm.ShowDialog();

        }

        private void ShowEventsBtn_Click(object sender, EventArgs e)
        {
            Ddata.UpdateDropStatus();
            EventForm evForm = new EventForm();
            evForm.ShowDialog();
        }

        private void ToDoManagerComponent_Load(object sender, EventArgs e)
        {
            //DeadlineLabel Update.
            DeadlineLabel.Text = Pdata.getNearestDeadline();
            //EventLabel Update.
            EventLabel.Text = Edata.getNextEvent();
            //DailyDatGrid Update.
            DailyDataGrid.DataSource = Ddata.ReadDataTable();
            DailyDataGrid.Columns["ID"].Visible = false;
            DailyDataGrid.Columns["Name1"].Visible = false;
            DailyDataGrid.Columns["Status"].Visible = false;
            DataGridViewComboBoxColumn checkboxes = new DataGridViewComboBoxColumn() { Name = "DONE", HeaderText = "Check", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells };
            StatusData Status = new StatusData();
            checkboxes.DataSource = Status.ReadDataTableForDaily();
            checkboxes.DisplayMember = "Name";
            checkboxes.ValueMember = "ID";
            // bind với cột status.
            checkboxes.DataPropertyName = "Status";
            DailyDataGrid.Columns.Add(checkboxes);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DoingThings doingThings = new DoingThings();
            doingThings.ShowDialog();
        }
    }
}
