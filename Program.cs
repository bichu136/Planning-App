﻿using System;
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
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            
            FileStream ThoiTietFile = new FileStream("ThoiTiet.txt",FileMode.OpenOrCreate,FileAccess.Write);
            ThoiTietFile.Close();
            string t = File.ReadAllText("ThoiTiet.txt");
            ThoiTiet = t;    

            SQLiteManage manager = new SQLiteManage();
            manager.CreateDatabase();
            ThingsToDoData ttdData = new ThingsToDoData();
            ttdData.UpdateDropStatus();
            DailyData dData = new DailyData();
            dData.UpdateNewDay();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(mainForm);
            //Application.Run(new SkinForm());
        }

    }
}
