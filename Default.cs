using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An
{
    class Default
    {
        public static int DayofWeek = 7;
        public static int DayofVertical = 6;
        public static int Width = 93;
        public static int Height = 48;
        public static int Margin = 6;
        public static int IndexTab = 10;
        public static int UCWidth = 986;
        public static int UCHeight = 565;
        static public double Distance = 50;
        static public double Number = 10;
        //static public string[] TextList = { "Cooking", "Study", "Sport", "Game", "Travel", "Movie", "HouseHold", "Diplomacy", "Goal", "SelfImprove" };
        static public Color color = Color.FromArgb(0,0,0,0);
        static public Color DataGridColor = Color.FromArgb(68,119,132);
        static public Color DayOfWeekButtonColor = Color.FromArgb(13, 79, 72);
        static public Color DayOfWeekButtonTextColor = Color.White;
        static public Color DayOfMonthColor = Color.FromArgb(65, 124, 129);

        public static void SkipKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public static void OnlyNumberPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public static void RemoveKeyPressEvent(System.Windows.Forms.TextBox b)
        {
            FieldInfo f1 = typeof(Control).GetField("KeyPress",
                BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(b);
            PropertyInfo pi = b.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            list.RemoveHandler(obj, list[obj]);
        }
    }
}
