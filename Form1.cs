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


namespace Do_An
{
    
    public partial class MainForm : Form
    {
        #region Properties Of Class
        DailyData Ddata = new DailyData();
        private AddThingToDoForm addThingToDoForm;
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

        #region Celendar
        private void LoadCanlenderMatrix()
        {
            ButtonManeger = new List<List<Button>>();
            Button OldButton = new Button() { Width = 0, Height = 0, Location = new Point(-Default.Margin, Default.IndexTab) };
            for (int i = 0; i < Default.DayofVertical; i++)
            {
                ButtonManeger.Add(new List<Button>());
                for (int j = 0; j < Default.DayofWeek; j++)
                {
                    Button NewButton = new Button() { Width = Default.Width, Height = Default.Height };
                    NewButton.Location = new Point(OldButton.Location.X + OldButton.Width + Default.Margin, OldButton.Location.Y);
                    panelMatrix.Controls.Add(NewButton);
                    OldButton = NewButton;
                    NewButton.Click += NewButton_Click;
                    NewButton.DoubleClick += NewButton_DoubleClick;
                    ButtonManeger[i].Add(NewButton);
                }
                OldButton = new Button() { Width = 0, Height = 0, Location = new Point(-Default.Margin, OldButton.Location.Y + Default.Height + Default.Margin + Default.IndexTab) };
            }
            SetDefaultDay();
        }

        private void NewButton_DoubleClick(object sender, EventArgs e)
        {
            //addThingToDoForm.
            //addThingToDoForm.Show();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            DateTime dateTime = dateTimePickerMainForm.Value;
            int Index1 = 0;
            int Index2 = 0;
            for (int i = 0; i < ButtonManeger.Count; i++)
            {
                for (int j = 0; j < ButtonManeger[i].Count; j++)
                {
                    Button Temp = ButtonManeger[i][j];
                    if (button == Temp)
                    {
                        Index2 = j;
                        Index1 = i;
                    }
                }
            }
            Button button1 = ButtonManeger[Index1][Index2];
            try
            {
                int Range = int.Parse(button1.Text) - dateTime.Day;
                dateTimePickerMainForm.Value = dateTime.AddDays(Range);
            }
            catch
            {
                return;
            }
            

        }
        private void NewButton_Click1(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            MessageBox.Show(x.Location.X.ToString() +" "+ x.Location.Y.ToString()); ;

        }
        private int DayOfMonth(DateTime dateTime)
        {
            switch (dateTime.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((dateTime.Year % 4 == 0 && dateTime.Year % 100 != 0) || dateTime.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }

        public void ClearValueinMatrix()
        {
            for (int i = 0; i < ButtonManeger.Count; i++)
            {
                for (int j = 0; j < ButtonManeger[i].Count; j++)
                {
                    Button button = ButtonManeger[i][j];
                    button.Text = "";
                    button.BackColor = Color.White;
                }
            }
        }

        public void AddNumberToMaxtrix(DateTime dateTime)
        {
            ClearValueinMatrix();
            DateTime Target = new DateTime(dateTime.Year, dateTime.Month, 1);
            int Line = 0;

            for (int i = 1; i <= DayOfMonth(dateTime); i++)
            {
                int Column = dayOfWeek.IndexOf(Target.DayOfWeek.ToString());
                Button button = buttonManeger[Line][Column];
                button.Text = i.ToString();
                Column++;

                if (CompareDay(Target, DateTime.Now))
                {
                    button.BackColor = Color.Aqua;
                }

                if (CompareDay(Target, dateTime))
                {
                    button.BackColor = Color.Orange;
                }

                if (Column > 6)
                    Line++;
                Target = Target.AddDays(1);
            }
        }

        private bool CompareDay(DateTime dateTime1, DateTime dateTime2)
        {
            return dateTime1.Year == dateTime2.Year && dateTime1.Month == dateTime2.Month && dateTime1.Day == dateTime2.Day;
        }

        private void SetDefaultDay()
        {
            dateTimePickerMainForm.Value = DateTime.Now;
        }

        private void dateTimePickerMainForm_ValueChanged(object sender, EventArgs e)
        {
            AddNumberToMaxtrix((sender as DateTimePicker).Value);
        }

        private void buttonLastMonth_Click(object sender, EventArgs e)
        {
            dateTimePickerMainForm.Value = dateTimePickerMainForm.Value.AddMonths(-1);
        }

        private void buttonNextMonth_Click(object sender, EventArgs e)
        {
            dateTimePickerMainForm.Value = dateTimePickerMainForm.Value.AddMonths(1);
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            SetDefaultDay();
        }

        //private void AddEvent_Click(object sender, EventArgs e)
        //{
        //    this.Visible = false;
        //    AddEventForm addEventForm = new AddEventForm();
        //    addEventForm.ShowDialog();
        //    this.Visible = true;
        //}
        #endregion
        public MainForm()
        {


            InitializeComponent();
            LoadCanlenderMatrix();
            
            //manager.InsertToTTD("DO_AN", "Thuc hien do an mon hoc lap trinh truc quan",2,3,4,5,"DO_AN","1","1");
            //manager.InsertToRecord("DO_AN", DateTime.Today.ToString(), DateTime.Today.ToString(), DateTime.Today.ToString(), "note here");
            //MessageBox.Show(Program.manager.LoadFromTable());
            AddJobsBtn.Click += AddJobs_Click;
            DataGridViewCheckBoxColumn checkboxes = new DataGridViewCheckBoxColumn() { Name = "DONE", HeaderText = "Check", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells };
            
            DailyDataGrid.Columns.Add(checkboxes);
            DailyDataGrid.CellValueChanged += DailyDataGrid_CellValueChanged;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //DeadlineLabel Update.
            DeadlineLabel.Text = Pdata.getNearestDeadline();
            //EventLabel Update.
            label2.Text = Edata.getNextEvent();

            //DailyDatGrid Update.
            DailyDataGrid.DataSource = Ddata.ReadDataTable();
            DailyDataGrid.Columns["ID"].Visible = false;
            DailyDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DailyDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DailyDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Weahter Update
            WeatherForecast.weatherForecast.WeatherForecast_Load();
        }

        private void DailyDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if(e.ColumnIndex != dg.Columns["Done"].Index)
            {
                return;
            }

            if ((bool)dg.Rows[e.RowIndex].Cells["Done"].Value)
            {
                Ddata.UpdateStatusByID(dg.Rows[e.RowIndex].Cells["ID"].Value.ToString(),ThingsToDo.statuses.Done);
                dg.Rows[e.RowIndex].Cells["status"].Value = (int)ThingsToDo.statuses.Done;
                dg.Update();
            }
            else
            {
                Ddata.UpdateStatusByID(dg.Rows[e.RowIndex].Cells["ID"].Value.ToString(),ThingsToDo.statuses.Ongoing);
                dg.Rows[e.RowIndex].Cells["status"].Value = (int)ThingsToDo.statuses.Ongoing;
                dg.Update();
            }
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

            DeadlineLabel.Text = Pdata.getNearestDeadline();
            label2.Text = Edata.getNextEvent();
            DailyDataGrid.DataSource = Ddata.ReadDataTable();
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

        private void button3_Click(object sender, EventArgs e)
        {
            EventForm evForm = new EventForm();
            evForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
