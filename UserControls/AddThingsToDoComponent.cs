using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Do_An
{
    public partial class AddThingsToDoComponent : DevExpress.XtraEditors.XtraUserControl
    {
        bool flag;
        private Dictionary<long, int> Scores;
        private StatData statData = new StatData();
        TypeData typeData = new TypeData();
        StatData Data = new StatData();

        public StatData data { get => Data; set => Data = value; }

        public AddThingsToDoComponent()
        {
            InitializeComponent();
            HideExComponent();
            Scores = new Dictionary<long, int>();
            //----------Add Events----------//
            this.Load += AddThingToDo_Load;
            NewStatBtn.Click += AddNewStat;

            ScoreTxtBox.KeyPress += Default.OnlyNumberPress;
            ScoreTxtBox.TextChanged += ScoreChange;
            TypeCbBox.KeyPress += Default.SkipKeyPress;
            statsCbBox.KeyPress += Default.SkipKeyPress;

            TypeCbBox.DataSource = typeData.ReadDataTable();
            TypeCbBox.DisplayMember = "Name";
            TypeCbBox.ValueMember = "ID";
            TypeCbBox.SelectedValueChanged += TypeChange;

            TypeCbBox.SelectedIndex = 1;
            AddBtn.Click += AddThingsToDo;
            //in load event
            statsCbBox.SelectedValueChanged += StatsChange;

            
            Ex1CbBox.Items.AddRange(Enum.GetNames(typeof(DayOfWeek)));
            Ex1CbBox.Items.Add("Alldays");
        }
        private void AddNewStat(object sender, EventArgs e)
        {
            AddStatsForm addStatsForm = new AddStatsForm(this);
            addStatsForm.ShowDialog();
        }

        private void TypeChange(object sender, EventArgs e)
        {
            HideExComponent();
            try
            {
                Default.RemoveKeyPressEvent(Ex1TxtBox);
                Default.RemoveKeyPressEvent(Ex2TxtBox);
            }
            catch (Exception exp)
            {

            }
            switch ((long)TypeCbBox.SelectedValue)
            {
                case (long)ThingsToDo.types.Objective:
                    ObjectiveShow();
                    break;
                case (long)ThingsToDo.types.Daily:
                    DailyShow();
                    break;
                case (long)ThingsToDo.types.Event:
                    EventShow();
                    break;
                case (long)ThingsToDo.types.Project:
                    ProjectShow();
                    break;
            }
        }

        #region Show
        private void ProjectShow()
        {
            Ex1Lbl.Text = "Dealine";
            Ex1Lbl.Show();
            Ex1DateTime.Show();
            Ex1ChkBox.Show();
        }

        private void EventShow()
        {
            Ex1Lbl.Text = "Begin At";
            Ex1Lbl.Show();
            Ex1DateTime.Show();
            //Ex2Lbl.Text = "End At";
            //Ex2Lbl.Show();
            //Ex2DateTime.Show();
        }

        private void DailyShow()
        {
            Ex2Lbl.Text = "Day to do";
            Ex2Lbl.Show();
            Ex1CbBox.Show();
        }
        private void ObjectiveShow()
        {
            Ex1Lbl.Text = "Goal";
            Ex1Lbl.Show();
            Ex1TxtBox.KeyPress += Default.OnlyNumberPress;
            Ex1TxtBox.Show();
            Ex2Lbl.Text = "đơn vị:";
            Ex2Lbl.Show();
            Ex2TxtBox.Show();
        }
        #endregion 

        private void AddThingsToDo(object sender, EventArgs e)
        {
            if (!checkReqirement())
            {
                XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default,"Wrong filling");
                return;
            }
            ThingsToDo input;
            ThingsToDoData data;
            Do_An.TTDStatsData StatData = new TTDStatsData();

            switch (TypeCbBox.SelectedIndex)
            {
                case 0:
                    input = new Objective(NameTxtBox.Text, Scores, DateTime.Now, Convert.ToInt32(Ex1TxtBox.Text), Ex2TxtBox.Text);
                    data = new ObjectiveData();
                    break;
                case 1:
                    input = new Daily(NameTxtBox.Text, Scores, DateTime.Now, 1, Ex1CbBox.SelectedIndex);
                    data = new DailyData();
                    break;
                case 2:
                    input = new Event(NameTxtBox.Text, Scores, DateTime.Now, Ex1DateTime.Value);
                    data = new EventData();
                    break;
                case 3:
                    input = new Project(NameTxtBox.Text, Scores, DateTime.Now, Ex1DateTime.Value, Ex1ChkBox.Checked);
                    data = new ProjectData();
                    break;
                default:
                    input = new ThingsToDo();
                    data = new ThingsToDoData();
                    break;
            }
            //Program.manager.Data.Add(input);
            input.id = data.Insert(input).ToString();
            StatData.Insert(input);
            XtraMessageBox.Show("To Do Confirm!", "mesasge", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void StatsChange(object sender, EventArgs e)
        {
            try
            {
                ScoreTxtBox.Text = Scores[(long)statsCbBox.SelectedValue].ToString();
            }
            catch (Exception ex) { }
        }

        private void ScoreChange(object sender, EventArgs e)
        {
            if (ScoreTxtBox.Text != "")
                try
                {
                    Scores[(long)statsCbBox.SelectedValue] = Convert.ToInt32(ScoreTxtBox.Text);
                }
                catch (Exception exp)
                {

                }
        }

        private void HideExComponent()
        {
            Ex1Lbl.Hide();
            Ex2Lbl.Hide();
            Ex1TxtBox.Hide();
            Ex2TxtBox.Hide();
            Ex1DateTime.Hide();
            Ex2DateTime.Hide();
            Ex1CbBox.Hide();
            Ex1ChkBox.Hide();
        }

        private void AddThingToDo_Load(object sender, EventArgs e)
        {
            Dictionary<long, int> Old_Scores = this.Scores;
            DataTable dt = data.ReadDataTable();
            statsCbBox.DataSource = dt;
            statsCbBox.DisplayMember = "Name";
            statsCbBox.ValueMember = "ID";
            foreach (DataRowView value in statsCbBox.Items)
            {

                if (Old_Scores.ContainsKey((long)value["ID"]) == false)
                {
                    this.Scores.Add((long)value["ID"], 0);
                }
            }
        }
        private bool checkReqirement()
        {
            
            if (NameTxtBox.Text.Length == 0)
            {
                return false;
            }
            if (ScoreTxtBox.Text.Length == 0)
            {
                return false;
            }
            if (Ex1TxtBox.Visible == true)
                if (Ex1TxtBox.Text.Length == 0)
                    return false;
            if (Ex2TxtBox.Visible == true)
                if (Ex2TxtBox.Text.Length == 0)
                    return false;
            if (Ex1CbBox.Visible == true)
                if (Ex1CbBox.Text.Length == 0)
                    return false;
            if (statsCbBox.Text.Length == 0)
                return false;
            if(Ex1DateTime.Visible ==true)
                if (Ex1DateTime.Value < DateTime.Now)
                    return false;
            if (Ex2DateTime.Visible == true)
                if (Ex2DateTime.Value < DateTime.Now)
                    return false;
            return true;

        }
    }
}

