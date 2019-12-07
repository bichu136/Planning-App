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
    public partial class DoingThings : Form
    {
        TypeData typedata;
        ThingsToDoData ttdData;
        DailyData dData;
        EventData eData;
        ProjectData pData;
        ObjectiveData oData;
        TimeComponent timeComponent;
        ThingsToDoData cursor;
        DataTable Namedt;
        RecordData rData;
        public DoingThings()
        {
            rData = new RecordData();
            timeComponent = new TimeComponent() { Location= new Point(12,100)};
            typedata = new TypeData();
            ttdData = new ThingsToDoData();
            eData = new EventData();
            dData = new DailyData();
            pData = new ProjectData();
            oData = new ObjectiveData();
            InitializeComponent();
            this.Controls.Add(timeComponent);
            CurrentTxtBox.KeyPress += Default.OnlyNumberPress;
            TypeCbBox.DataSource = typedata.ReadDataTable();
            TypeCbBox.ValueMember = "ID";
            TypeCbBox.DisplayMember = "Name";
            
            TypeCbBox.SelectedIndex = 1;
        }
        private void NameCbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Max = 0;
            ComboBox x = (ComboBox)sender;
            DataTable dt= (DataTable)x.DataSource;
            switch ((long)TypeCbBox.SelectedValue)
            {
                 case (long)ThingsToDo.types.Project:
                     HasPlanChkBox.Checked = pData.isCheck(NameCbBox.SelectedValue.ToString());
                     Max = 50;
                     break;
                 case (long)ThingsToDo.types.Objective:
                     UnitLbl.Text = oData.Unit(NameCbBox.SelectedValue.ToString());
                     Max = 75;
                     break;
                 default:
                     Max = 20;
                     break;
                }
            addChart(x.SelectedValue.ToString(), Max);
            UpDateCurrentAndStatus();
        }

        private void UpDateCurrentAndStatus()
        {
            StatusLbl.Text = "";
            try
            {
                long goal = 0;
                switch ((long)TypeCbBox.SelectedValue)
                {
                    case 3:
                    case 2:
                        CurrentLbl.Text = "Times ";
                        ValueCurrentLbl.Text = rData.CountOfCurrent(NameCbBox.SelectedValue.ToString()).ToString();
                        break;
                    case 1:
                        goal = oData.getGoal(NameCbBox.SelectedValue.ToString());
                        CurrentLbl.Text = "Current";
                        ValueCurrentLbl.Text = oData.Unit(NameCbBox.SelectedValue.ToString());
                        ValueCurrentLbl.Text = rData.SumOfCurrent(NameCbBox.SelectedValue.ToString()).ToString() +"/"+goal.ToString()+" "+ ValueCurrentLbl.Text;
                        break;
                    case 4:
                        
                        CurrentLbl.Text = "Current";
                        ValueCurrentLbl.Text = rData.SumOfCurrent(NameCbBox.SelectedValue.ToString()).ToString() + "%";
                        break;
                }
                String Status = ttdData.ReadStatusByID(NameCbBox.SelectedValue.ToString());
                int t = Convert.ToInt32(Status);
                StatusLbl.Text = ((ThingsToDo.statuses)t).ToString();
            }
            catch
            {

            }
            

            
        }

        private void TypeCbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox input = (ComboBox)sender;
            try
            {
                if (input.SelectedValue == null)
                {
                    MessageBox.Show("Chưa có công việc loại này");
                }
                HideAll();
                switch ((long)input.SelectedValue)
                {

                    case (long)ThingsToDo.types.Daily:
                        cursor = dData;
                        break;
                    case (long)ThingsToDo.types.Event:
                        cursor = eData;
                        break;
                    case (long)ThingsToDo.types.Objective:
                        cursor = oData;
                        LoadOpjective();
                        break;
                    case (long)ThingsToDo.types.Project:
                        cursor = pData;
                        LoadProject();
                        break;
                }

                Namedt = cursor.ReadDataTableForDoing();
                //NameCbBox.DataSource = null;
                NameCbBox.DataSource = Namedt;
                NameCbBox.ValueMember = "ID";
                NameCbBox.DisplayMember = "Name";
                if(Namedt.Rows.Count == 0)
                {
                    CurrentLbl.Hide();
                    StatusLbl.Hide();
                    StatusLbl1.Hide();
                }
            }
            catch(Exception ex)
            {
                HideAll();
            }
        }
        private void LockAll()
        {

        }
        private void LoadProject()
        {
            UnitLbl.Text = "%";
            HasPlanChkBox.Show();
            UnitLbl.Show();
            CurrentTxtBox.Show();
        }
        private void LoadOpjective()
        {
            
            UnitLbl.Show();
            CurrentTxtBox.Show();
        }
        private void HideAll()
        {
            HasPlanChkBox.Hide();
            UnitLbl.Hide();
            CurrentTxtBox.Hide();

        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            if (CheckRequirement())
            {
                RecordData Rdata = new RecordData();
                cursor.UpdateByDoing(NameCbBox.SelectedValue.ToString(), (long)ThingsToDo.statuses.Done);
                switch ((long)TypeCbBox.SelectedValue)
                {
                    default:
                        Rdata.Insert(new Record() { TTD_ID = (long)NameCbBox.SelectedValue, Date = DateTime.Now.Date, Current = 0 });
                        break;
                    case (long)ThingsToDo.types.Objective:
                    case (long)ThingsToDo.types.Project:
                        Rdata.Insert(new Record() { TTD_ID = (long)NameCbBox.SelectedValue, Date = DateTime.Now.Date, Current = Convert.ToInt32(CurrentTxtBox.Text) });
                        break;
                }
                this.Close();
                return;
            }
            MessageBox.Show("bạn chưa điền đủ thông tin.");
        }
        private void addChart(String TTDID, double Max)
        {
            StatPanel.Controls.Clear();
            if (TTDID == "")
            {
                return;
            }
            
            StatPanel.Controls.Add(new UserControls.StatsComponent(TTDID,Max));
        }
        private bool CheckRequirement()
        {
            if (CurrentTxtBox.Visible)
            {   
                return (CurrentTxtBox.Text != "");
            }
            if (NameCbBox.SelectedValue == null)
            {
                return false;
            }
            return true;
        }

        private void NamDS_Changed(object sender, EventArgs e)
        {
                       
        }

        private void InformPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
