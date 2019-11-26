using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        static public double Distance = 100;
        static public double Number = 10;
        static public string[] TextList = { "Cooking", "Study", "Sport", "Game", "Travel", "Movie", "HouseHold", "Diplomacy", "Goal", "SelfImprove" };
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

        public static void RemoveKeyPressEvent(TextBox b)
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
