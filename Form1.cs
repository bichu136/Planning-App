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
    
    public partial class MainForm : Form
    {
        private AddThingToDoForm addThingToDoForm;
        public MainForm()
        {
            InitializeComponent();
            //manager.InsertToTTD("DO_AN", "Thuc hien do an mon hoc lap trinh truc quan",2,3,4,5,"DO_AN","1","1");
            //manager.InsertToRecord("DO_AN", DateTime.Today.ToString(), DateTime.Today.ToString(), DateTime.Today.ToString(), "note here");
            //MessageBox.Show(Program.manager.LoadFromTable());
            this.FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.manager.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalendarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddJobs_Click(object sender, EventArgs e)
        {
            addThingToDoForm = new AddThingToDoForm();
            addThingToDoForm.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
