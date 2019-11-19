using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An
{
    static class Program
    {
        public static String _ThoiTiet;

        public static String ThoiTiet { get => _ThoiTiet; set => _ThoiTiet = value; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            FileStream ThoiTietFile = new FileStream("ThoiTiet.txt",FileMode.OpenOrCreate,FileAccess.Write);
            ThoiTietFile.Close();
            string t = File.ReadAllText("ThoiTiet.txt");
            ThoiTiet = t;    

            SQLiteManage manager = new SQLiteManage();
            manager.CreateDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }

    }
}
