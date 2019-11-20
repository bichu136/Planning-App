using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An
{
    public partial class AddThingToDoForm : Form
    {
        bool flag;
        private Dictionary<long,int> Scores;
        StatData statData = new StatData();
        TypeData typeData = new TypeData();
        StatData data = new StatData();
        public AddThingToDoForm(long x)
        {
            
        }
        public AddThingToDoForm()
        {
            InitializeComponent();
            HideExComponent();
            Scores = new Dictionary<long, int>();
            //----------Add Events----------//
            NewStatBtn.Click += AddNewStat;

            ScoreTxtBox.KeyPress += OnlyNumberPress;
            ScoreTxtBox.TextChanged += ScoreChange;
            TypeCbBox.KeyPress += SkipKeyPress;
            StatsCbBox.KeyPress += SkipKeyPress;

            TypeCbBox.DataSource = typeData.ReadDataTable();
            TypeCbBox.DisplayMember = "Name";
            TypeCbBox.ValueMember = "ID";
            TypeCbBox.SelectedValueChanged += TypeChange;

            TypeCbBox.SelectedIndex = 1;
            AddBtn.Click += AddThingsToDo;
            //in load event

            StatsCbBox.SelectedValueChanged += StatsChange;

            foreach (var item in StatsCbBox.Items)
            {

                Scores.Add((int)item, 0);
            }
        }
        private void SkipKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void OnlyNumberPress(object sender, KeyPressEventArgs e)
        {
           if ((e.KeyChar<'0' || e.KeyChar > '9')&& e.KeyChar!= 8)
           {
                e.Handled = true;
           }
        }

        private void RemoveKeyPressEvent(TextBox b)
        {
            FieldInfo f1 = typeof(Control).GetField("KeyPress",
                BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(b);
            PropertyInfo pi = b.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            list.RemoveHandler(obj, list[obj]);
        }
        private void AddNewStat(object sender, EventArgs e)
        {
            Form addStat= new Form();
            Label Namelbl = new Label() { Location = new Point(10, 10),AutoSize=true, Text = "Name" };
            TextBox NameTxtBox = new TextBox();
            NameTxtBox.Location = new Point(Namelbl.Location.X+Namelbl.Size.Width,Namelbl.Location.Y-3);
            Button addBtn = new Button() { Text = "Add", Location = new Point(NameTxtBox.Location.X,NameTxtBox.Location.Y+NameTxtBox.Size.Height+2),AutoSize=true };
            RichTextBox DesTxtBox = new RichTextBox() {Location= new Point(NameLbl.Location.X,Namelbl.Location.Y+Namelbl.Size.Height+50),Size = new Size(addStat.Size.Width-Location.X-10,addStat.Size.Height-Location.Y-50) };
            Label Deslbl = new Label() { Location = new Point(DesTxtBox.Location.X, DesTxtBox.Location.Y - 50), Text = "Description",AutoSize=true };
            addStat.FormClosed += (object Sender1, FormClosedEventArgs E1) => { AddThingToDoForm_Load(Sender1, E1); };
            addBtn.Click += (object Sender, EventArgs E) =>{                
                List<string> buffer = new List<string>() { NameTxtBox.Text, DesTxtBox.Text };
               
                data.Insert(buffer);
                //Program.manager.Insert("Stats", new List<string> { "Name", "Description" }, new List<string> { Buffer1, Buffer2 });
                this.StatsCbBox.DataSource = data.ReadDataTable();
                addStat.Close();
            };
            addStat.Controls.Add(Namelbl);
            addStat.Controls.Add(NameTxtBox);
            addStat.Controls.Add(addBtn);
            addStat.Controls.Add(DesTxtBox);
            addStat.Controls.Add(Deslbl);
            addStat.ShowDialog();
            this.AddThingToDoForm_Load(sender,e);
        }

        private void TypeChange(object sender, EventArgs e)
        {
            HideExComponent();
            try
            {
                RemoveKeyPressEvent(Ex1TxtBox);
                RemoveKeyPressEvent(Ex2TxtBox);
            }
            catch(Exception exp)
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
            Ex1Lbl.Text = "factor";
            Ex1Lbl.Show();
            Ex1TxtBox.KeyPress += OnlyNumberPress;
            Ex1TxtBox.Show();
        }
        private void ObjectiveShow()
        {
            Ex1Lbl.Text = "Goal";
            Ex1Lbl.Show();
            Ex1TxtBox.KeyPress += OnlyNumberPress;
            Ex1TxtBox.Show();
        }
        #endregion 

        private void AddThingsToDo(object sender, EventArgs e)
        {
            ThingsToDo input;
            ThingsToDoData data;
            Do_An.TTDStatsData StatData = new TTDStatsData();
            switch (TypeCbBox.SelectedIndex)
            {
                case 0:
                    input = new Objective(NameTxtBox.Text,Scores,DateTime.Now,Convert.ToInt32(Ex1TxtBox.Text)) ;
                    data = new ObjectiveData();
                    break;
                case 1:
                    input = new Daily(NameTxtBox.Text, Scores, DateTime.Now, Convert.ToInt32(Ex1TxtBox.Text));
                    data = new DailyData();
                    break;
                case 2:
                    input = new Event( NameTxtBox.Text, Scores, DateTime.Now, Ex1DateTime.Value);
                    data = new EventData();
                    break;
                case 3:
                    input = new Project( NameTxtBox.Text, Scores, DateTime.Now, Ex1DateTime.Value);
                    data = new ProjectData();
                    break;
                default:
                    input = new ThingsToDo();
                    data = new ThingsToDoData();
                    break;
            }
            //Program.manager.Data.Add(input);
            data.Insert(input);
            StatData.Insert(input);
            this.Close();
        }

        
        private void StatsChange(object sender, EventArgs e)
        {
            try
            {
                ScoreTxtBox.Text = Scores[(long)StatsCbBox.SelectedValue].ToString();
            }
            catch(Exception ex) { }
        }
        
        private void ScoreChange(object sender,EventArgs e)
        {
            if(ScoreTxtBox.Text!="")
            try
            {
                Scores[(long)StatsCbBox.SelectedValue] = Convert.ToInt32(ScoreTxtBox.Text);
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
        }

        private void AddThingToDoForm_Load(object sender, EventArgs e)
        {
            Dictionary<long,int> Old_Scores = this.Scores;
            DataTable dt = statData.ReadDataTable();
            StatsCbBox.DataSource = dt;
            StatsCbBox.DisplayMember = "Name";
            StatsCbBox.ValueMember = "ID";
            foreach(DataRowView value in StatsCbBox.Items)
            {

                if(Old_Scores.ContainsKey((long)value["ID"])==false){
                    this.Scores.Add((long)value["ID"], 0);
                }
            }
        }
    }
}
