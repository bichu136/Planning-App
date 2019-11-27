using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Do_An.UserControls;

namespace Do_An
{
    
    public partial class MainForm : Form
    {
        #region Properties Of Class
        
        private AddThingToDoForm addThingToDoForm;
        ToDoManagerComponent toDoManager = new ToDoManagerComponent();
        Weather weather;
        WeatherForecast forecast = new WeatherForecast();
        DailyData Ddata = new DailyData();
        ProjectData Pdata = new ProjectData();
        EventData Edata = new EventData();        
        private List<List<Button>> buttonManeger;
        private ChartComponent chartComponent = new ChartComponent("0",50);
        public List<List<Button>> ButtonManeger
        {
            //get => buttonManeger; 
            //set => buttonManeger = value; 
            get { return buttonManeger; }
            set { buttonManeger = value; }
        }

        private List<string> dayOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion

        public MainForm()
        {
            InitializeComponent();
            weather = new Weather();
            DataGridViewCheckBoxColumn checkboxes = new DataGridViewCheckBoxColumn() { Name = "DONE", HeaderText = "Check", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells };           
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ////Weather Update.
            //if (Program.ThoiTiet != "")
            //{
            //    try 
            //    {
            //        weather.getData(Program.ThoiTiet);
            //        WTimeLabel.Text = weather.Days[0].ToString();
            //        WTenpfLbl.Text = weather.TempF[0];
            //        WsymbLbl.Text = weather.Weathers[0];
            //    }
                
            //    catch (Exception ex)
            //    {

            //    }
                
            //}
        }
        private void CalendarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            DailyForm dailyForm = new DailyForm();
            dailyForm.ShowDialog();   
        }

        private void btnPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void makePlanBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Events__Click(object sender, EventArgs e)
        {
           
        }

        private void Deadline_Click(object sender, EventArgs e)
        {
            DeadlineForm dlForm = new DeadlineForm();
            dlForm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.ShowDialog();
            this.Form1_Load(sender, e);
        }

        private void UpdateDailyBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlsPanel.Controls.Clear();
            UserControlsPanel.Controls.Add(toDoManager);
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlsPanel.Controls.Clear();
            UserControlsPanel.Controls.Add(new CalendarComponent());
        }

        private void weatherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlsPanel.Controls.Clear();
            UserControlsPanel.Controls.Add(new WeatherForecast());
        }

        private void AddJobsBtn_Click(object sender, EventArgs e)
        {
            AddThingToDoForm addThingToDo = new AddThingToDoForm();
            addThingToDo.ShowDialog();
        }
        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlsPanel.Controls.Clear();
            UserControlsPanel.Controls.Add(chartComponent);
        }
        private void addJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddThingsToDoComponent addThingToDo= new AddThingsToDoComponent();
            UserControlsPanel.Controls.Clear();
            UserControlsPanel.Controls.Add(addThingToDo);
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsComponent Setting = new SettingsComponent();
            UserControlsPanel.Controls.Clear();
            UserControlsPanel.Controls.Add(Setting);
        }
    }
}
