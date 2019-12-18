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
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.LookAndFeel;

namespace Do_An
{
    
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        #region Properties Of Class
        
        Weather weather;
        WeatherForecast forecast = new WeatherForecast();
        DailyData Ddata = new DailyData();
        ProjectData Pdata = new ProjectData();
        EventData Edata = new EventData();        
        private List<List<Button>> buttonManeger;
        public List<List<Button>> ButtonManeger
        {
            //get => buttonManeger; 
            //set => buttonManeger = value; 
            get { return buttonManeger; }
            set { buttonManeger = value; }
        }


        private List<string> dayOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        private ToDoManagerComponent ToDoManager;
        public ToDoManagerComponent toDoManager { get => ToDoManager; set => ToDoManager = value; }

        private DefaultLookAndFeel lookAndFeel;

        public MainForm()
        {
            InitializeComponent();
            weather = new Weather();
            DataGridViewCheckBoxColumn checkboxes = new DataGridViewCheckBoxColumn() { Name = "DONE", HeaderText = "Check", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells };
            CalendarComponent calendarComponent = new CalendarComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Sharp");
        }
        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toDoManager = new ToDoManagerComponent();
            toDoManager.Size = UserControlsPanel.Size;
            toDoManager.Appearance.BackColor = Default.color;
            UserControlsPanel.Controls.Clear();
            UserControlsPanel.Controls.Add(toDoManager);
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarComponent calendarComponent = new CalendarComponent();
            calendarComponent.Size = UserControlsPanel.Size;
            calendarComponent.Appearance.BackColor = Default.color;
            UserControlsPanel.Controls.Clear();
            UserControlsPanel.Controls.Add(calendarComponent);
        }

        private void weatherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeatherForecast weatherForecast = new WeatherForecast();
            weatherForecast.Size = UserControlsPanel.Size;
            weatherForecast.Appearance.BackColor = Default.color;
            UserControlsPanel.Controls.Clear();
            UserControlsPanel.Controls.Add(weatherForecast);
        }
        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartComponent chartComponent = new ChartComponent();
            chartComponent.Size = UserControlsPanel.Size;
            chartComponent.Appearance.BackColor = Default.color;
            UserControlsPanel.Controls.Clear();
            UserControlsPanel.Controls.Add(chartComponent);
        }
        private void addJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddThingsToDoComponent addThingToDo= new AddThingsToDoComponent();
            addThingToDo.Size = UserControlsPanel.Size;
            addThingToDo.Appearance.BackColor = Default.color;
            UserControlsPanel.Controls.Clear();
            UserControlsPanel.Controls.Add(addThingToDo);
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsComponent Setting = new SettingsComponent();
            Setting.Size = UserControlsPanel.Size;
            UserControlsPanel.Controls.Clear();
            UserControlsPanel.Controls.Add(Setting);
        }
        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            if (UserControlsPanel.Controls.Contains(toDoManager))
            {
                mainToolStripMenuItem_Click(sender, e);
            }
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            Form form = (Form)sender; 
            if (UserControlsPanel.Controls.Contains(toDoManager))
            {
                toDoManager.Size = new Size(form.Size.Width, form.Size.Height);
            }
        }

        private void skinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkinComponent skinComponent = new SkinComponent();
            skinComponent.Size = UserControlsPanel.Size;
            UserControlsPanel.Controls.Clear();
            UserControlsPanel.Controls.Add(skinComponent);
        }
    }
}
