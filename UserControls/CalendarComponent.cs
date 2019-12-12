using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An
{
    public partial class CalendarComponent : UserControl
    {
        private List<List<Button>> buttonManeger;
        private ToolTip Tips;
        public List<List<Button>> ButtonManeger
        {
            //get => buttonManeger; 
            //set => buttonManeger = value; 
            get { return buttonManeger; }
            set { buttonManeger = value; }
        }

        private List<string> dayOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public CalendarComponent()
        {
            Tips = new ToolTip();
            Tips.InitialDelay = 1000;
            Tips.ReshowDelay = 1000;
            Tips.AutoPopDelay = 5000;   
            InitializeComponent();
            SetWeeklyTask();
            LoadCanlenderMatrix();
        }

        private void WeekDayButtonSetup(Button weekdayButton)
        {
            DataTable info = (DataTable)weekdayButton.Tag;
            String x ="You have " + info.Rows.Count.ToString() +" thing to do on this weekday.";
            Tips.SetToolTip(weekdayButton,x);
            
        }
        private void DayButtonSetup(Button dayButton)
        {
            dayButton.Image = null;
            DataTable info = (DataTable)dayButton.Tag;
            String x = "You have " + info.Rows.Count.ToString() + " Event on this weekday.";
            Tips.SetToolTip(dayButton, x);
            dayButton.ImageAlign = ContentAlignment.BottomRight;
            if (info.Rows.Count > 0)
            {
                Image Temp = new Bitmap(@"resources//WeeklyAlert.png");
                dayButton.Image = new Bitmap(Temp,25,25);
            }


        }
        private void SetWeeklyTask()
        {

            DailyData dData = new DailyData();
            buttonMonday.ImageAlign = ContentAlignment.BottomRight;
            buttonTuesday.ImageAlign = ContentAlignment.BottomRight;
            buttonWednesday.ImageAlign = ContentAlignment.BottomRight;
            buttonFriday.ImageAlign = ContentAlignment.BottomRight;
            buttonSaturday.ImageAlign = ContentAlignment.BottomRight;
            buttonSunday.ImageAlign = ContentAlignment.BottomRight;
            buttonMonday.Tag = dData.getWeeklyTaskOn((int)DayOfWeek.Monday);
            buttonTuesday.Tag = dData.getWeeklyTaskOn((int)DayOfWeek.Tuesday);
            buttonWednesday.Tag = dData.getWeeklyTaskOn((int)DayOfWeek.Wednesday);
            buttonThursday.Tag = dData.getWeeklyTaskOn((int)DayOfWeek.Thursday);
            buttonFriday.Tag = dData.getWeeklyTaskOn((int)DayOfWeek.Friday);
            buttonSaturday.Tag = dData.getWeeklyTaskOn((int)DayOfWeek.Saturday);
            buttonSunday.Tag = dData.getWeeklyTaskOn((int)DayOfWeek.Sunday);
            WeekDayButtonSetup(buttonMonday);
            WeekDayButtonSetup(buttonTuesday);
            WeekDayButtonSetup(buttonWednesday);
            WeekDayButtonSetup(buttonThursday);
            WeekDayButtonSetup(buttonFriday);
            WeekDayButtonSetup(buttonSaturday);
            WeekDayButtonSetup(buttonSunday);
        }
        #region Calendar
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
            Button ThisBtn = (Button)sender;
            DataTable info = (DataTable)ThisBtn.Tag;
            //TODOS: mở form cho thấy các event trong ngày.
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
            //TODO: làm cái để nhấn button rồi load lại cái EventDgv
            Button ThisBtn = (Button)sender;
            DataTable info = (DataTable)ThisBtn.Tag;
            EventDgv.DataSource = info;
        }
        private void NewButton_Click1(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            MessageBox.Show(x.Location.X.ToString() + " " + x.Location.Y.ToString()); ;

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
            //ClearDeadlineNote();
            LoadPanelProject();
            DateTime Target = new DateTime(dateTime.Year, dateTime.Month, 1);
            int Line = 0;
            EventData EData = new EventData();
            
            for (int i = 1; i <= DayOfMonth(dateTime); i++)
            {
                int Column = dayOfWeek.IndexOf(Target.DayOfWeek.ToString());
                Button button = buttonManeger[Line][Column];
                button.Tag = EData.GetEventOn(new DateTime(dateTime.Year,dateTime.Month,i));
                button.Text = i.ToString();
                DayButtonSetup(button);
                //button.Tag = EventData.GetEventOn(new DateTime(dateTime.Year,dateTime.Month,i));
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
        public void LoadPanelProject()
        {
            //
            //TODO: tạo ra một panel ơ bên phải, show các deadlines còn hiện hữu của tháng, chỉ show tên thôi.
            //nếu cần lấy cái gì từ database thì hãy tạo 1 hàm ở trong SQLitemanageAndChild/ProjectData.cs
            //đọc thêm hướng dẫn ở mục project trên github để bk thêm thông tin về cách lấy dữ liệu. hoặc xem các hàm trc để hiểu rõ hơn.
            //
            ProjectData projectData = new ProjectData();
            DataTable dt = projectData.Read_OnGoingMonth(dateTimePickerMainForm.Value);
            ProjectDgv.DataSource = dt;
        }
    }
    
}
