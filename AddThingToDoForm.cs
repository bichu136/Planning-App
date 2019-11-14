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
        private Dictionary<string,int> Scores;
        StatData statData = new StatData();
        TypeData typeData = new TypeData();
        StatData data = new StatData();
        public AddThingToDoForm()
        {
            InitializeComponent();
            HideExComponent();

            Scores = new Dictionary<string, int>();
            //----------Add Events----------//
            NewStatBtn.Click += AddNewStat;

            ScoreTxtBox.KeyPress += OnlyNumberPress;
            ScoreTxtBox.TextChanged += ScoreChange;
            TypeCbBox.KeyPress += SkipKeyPress;
            StatsCbBox.KeyPress += SkipKeyPress;

            TypeCbBox.DataSource = typeData.ReadDataTable();
            TypeCbBox.DisplayMember = "Name";
            TypeCbBox.TextChanged += TypeChange;

            TypeCbBox.SelectedIndex = 1;
            AddBtn.Click += AddThingsToDo;
            //in load event
            StatsCbBox.DataSource = statData.ReadDataTable();
            StatsCbBox.DisplayMember = "Name";
            StatsCbBox.TextChanged += StatsChange;
            
            foreach(var item in StatsCbBox.Items)
            {
                Scores.Add(item.ToString(), 0);
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

        private void AddNewStat(object sender, EventArgs e)
        {
            Form addStat= new Form();
            Label Namelbl = new Label() { Location = new Point(10, 10),AutoSize=true, Text = "Name" };
            TextBox NameTxtBox = new TextBox();
            NameTxtBox.Location = new Point(Namelbl.Location.X+Namelbl.Size.Width,Namelbl.Location.Y-3);
            Button addBtn = new Button() { Text = "Add", Location = new Point(NameTxtBox.Location.X,NameTxtBox.Location.Y+NameTxtBox.Size.Height+2),AutoSize=true };
            RichTextBox DesTxtBox = new RichTextBox() {Location= new Point(NameLbl.Location.X,Namelbl.Location.Y+Namelbl.Size.Height+50),Size = new Size(addStat.Size.Width-Location.X-10,addStat.Size.Height-Location.Y-50) };
            Label Deslbl = new Label() { Location = new Point(DesTxtBox.Location.X, DesTxtBox.Location.Y - 50), Text = "Description",AutoSize=true };
            addBtn.Click += (object Sender, EventArgs E) =>{                
                List<string> buffer = new List<string>() { NameTxtBox.Text, DesTxtBox.Text };
               
                data.Insert(buffer);
                //Program.manager.Insert("Stats", new List<string> { "Name", "Description" }, new List<string> { Buffer1, Buffer2 });
                this.StatsCbBox.DataSource = data.ReadDataTable();
                Scores.Add(NameTxtBox.Text, 0);
                addStat.Close();
            };
            addStat.Controls.Add(Namelbl);
            addStat.Controls.Add(NameTxtBox);
            addStat.Controls.Add(addBtn);
            addStat.Controls.Add(DesTxtBox);
            addStat.Controls.Add(Deslbl);
            addStat.ShowDialog();
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
            switch (TypeCbBox.SelectedIndex)
            {
                case 0:
                    ObjectiveShow();
                    break;
                case 1:
                    DailyShow();
                    break;
                case 2:
                    EventShow();
                    break;
                case 3:
                    ProjectShow();
                    break;
            }
        }

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

        private void AddThingsToDo(object sender, EventArgs e)
        {
            ThingsToDo input;
            ThingsToDoData data;
            Do_An.TTDStatsData StatData = new TTDStatsData();
            switch (TypeCbBox.SelectedIndex)
            {
                case 0:
                    input = new Objective(IDTxtBox.Text,NameTxtBox.Text,Scores,DateTime.Now,Convert.ToInt32(Ex1TxtBox.Text)) ;
                    data = new ObjectiveData();
                    break;
                case 1:
                    input = new Daily(IDTxtBox.Text, NameTxtBox.Text, Scores, DateTime.Now, Convert.ToInt32(Ex1TxtBox.Text));
                    data = new DailyData();
                    break;
                case 2:
                    input = new Event(IDTxtBox.Text, NameTxtBox.Text, Scores, DateTime.Now, Ex1DateTime.Value);
                    data = new EventData();
                    break;
                case 3:
                    input = new Project(IDTxtBox.Text, NameTxtBox.Text, Scores, DateTime.Now, Ex1DateTime.Value);
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

        private void ObjectiveShow()
        {
            Ex1Lbl.Text = "Goal";
            Ex1Lbl.Show();
            Ex1TxtBox.KeyPress += OnlyNumberPress;
            Ex1TxtBox.Show();
        }
        private void StatsChange(object sender, EventArgs e)
        {
            ScoreTxtBox.Text = Scores[StatsCbBox.Text].ToString();
        }
        
        private void ScoreChange(object sender,EventArgs e)
        {
            if(ScoreTxtBox.Text!="")
            try
            {
                Scores[StatsCbBox.Text] = Convert.ToInt32(ScoreTxtBox.Text);
            }
            catch (Exception exp)
            {
                
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

        }
    }
}
