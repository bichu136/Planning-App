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
        public DoingThings()
        {
            timeComponent = new TimeComponent() { Location= new Point(12,100)};
            typedata = new TypeData();
            ttdData = new ThingsToDoData();
            InitializeComponent();
            
            TypeCbBox.DataSource = typedata.ReadDataTable();
            TypeCbBox.DisplayMember = "Name";
            TypeCbBox.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecordData RData = new RecordData();
            Record package = new Record((int)NameCbBox.SelectedValue, DateTime.Now.Date, getCurrent());
            RData.Insert(package);
            ttdData.UpdateWhenDoingSomethingByID((int)NameCbBox.SelectedValue);
            this.Close();
        }

        private int getCurrent()
        {
            if (flag = true)
            {
                return Convert.ToInt32(CurrentTxtBox);
            }
            return 0;
        }

        bool flag = false;
        private void NameCbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("NameCbBoxChangeSelected");
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
                switch ((int)input.SelectedValue)
                {

                    case (int)ThingsToDo.types.Daily:
                        cursor = dData;
                        break;
                    case (int)ThingsToDo.types.Event:
                        cursor = eData;
                        break;
                    case (int)ThingsToDo.types.Objective:
                        cursor = oData;
                        LoadOpjective();
                        break;
                    case (int)ThingsToDo.types.Project:
                        cursor = pData;
                        LoadProject();
                        break;
                }
                DataTable dt = cursor.ReadDataTableForDoing();
                NameCbBox.DataSource = dt;
                NameCbBox.DisplayMember = "Name";
                NameCbBox.ValueMember = "ID";
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

        }
        private void LoadOpjective()
        {
            HasPlanChkBox.Show();
        }
        private void HideAll()
        {
            HasPlanChkBox.Hide();
            UnitLbl.Hide();
            CurrentTxtBox.Hide();

        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            cursor.UpdateByDoing(NameCbBox.SelectedValue.ToString());
            RecordData Rdata = new RecordData();
            Rdata.Insert(new Record() { TTD_ID=(int)NameCbBox.SelectedValue , Date=DateTime.Now.Date,Current = getCurrent() });
        }
    }
}
