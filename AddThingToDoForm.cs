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
    public partial class AddThingToDoForm : Form
    {
        bool flag;
        private List<int> Scores;
        private String Buffer1;
        private String Buffer2;
        public AddThingToDoForm()
        {
            InitializeComponent();
            Scores = new List<int>();
            //----------Add Events----------//
            NewStatBtn.Click += AddNewStat;
            StatsCbBox.TextChanged += StatsChange;
            ScoreTxtBox.KeyPress += ChangeScorePoint;
            TypeCbBox.TextChanged += TypeChange;
            TypeCbBox.Items.AddRange(Program.manager.getTypes());
            
            Program.manager.StartReadFrom("Stat",new string[] {"name" });
            while (Program.manager.reader.Read())
            {
                StatsCbBox.Items.Add(Program.manager.reader.GetString(0));
                Scores.Add(0);
            }
            Program.manager.reader.Close();

        }

        private void ChangeScorePoint(object sender, KeyPressEventArgs e)
        {
           if ((e.KeyChar<'0' || e.KeyChar > '9')&& e.KeyChar!= 8)
           {
                e.Handled = true;
           }
        }

        private void AddNewStat(object sender, EventArgs e)
        {
            Buffer1 = "";
            Buffer2 = "";
            Form addStat= new Form();
            Label Namelbl = new Label() { Location = new Point(10, 10),AutoSize=true, Text = "Name" };
            TextBox NameTxtBox = new TextBox();
            NameTxtBox.Location = new Point(Namelbl.Location.X+Namelbl.Size.Width,Namelbl.Location.Y-3);
            Button addBtn = new Button() { Text = "Add", Location = new Point(NameTxtBox.Location.X,NameTxtBox.Location.Y+NameTxtBox.Size.Height+2),AutoSize=true };
            RichTextBox DesTxtBox = new RichTextBox() {Location= new Point(NameLbl.Location.X,Namelbl.Location.Y+Namelbl.Size.Height+50),Size = new Size(addStat.Size.Width-Location.X-10,addStat.Size.Height-Location.Y-50) };
            Label Deslbl = new Label() { Location = new Point(DesTxtBox.Location.X, DesTxtBox.Location.Y - 50), Text = "Description",AutoSize=true };
            addStat.Controls.Add(Namelbl);
            addStat.Controls.Add(NameTxtBox);
            addStat.Controls.Add(addBtn);
            addStat.Controls.Add(DesTxtBox);
            addStat.Controls.Add(Deslbl);
            addStat.ShowDialog();
            Buffer1 = NameTxtBox.Text;
            Buffer2 = DesTxtBox.Text;
        }

        private void TypeChange(object sender, EventArgs e)
        {
            switch (TypeCbBox.SelectedIndex)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:
                    break;
            }
        }
        private void StatsChange(object sender, EventArgs e)
        {
            ScoreTxtBox.Text = Scores[StatsCbBox.SelectedIndex].ToString();
        }
        
        private void ScoreChange(object sender,EventArgs e)
        {
            Scores[StatsCbBox.SelectedIndex] = Convert.ToInt32(ScoreTxtBox.Text);
        }
    }
}
