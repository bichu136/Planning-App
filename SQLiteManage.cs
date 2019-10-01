using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Do_An
{
    class SQLiteManage
    {
        private SQLiteConnection cnn;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private List<Jobs> Data;
        public enum Table{ Record = 1,ThingToDo = 0,Ex = 1};
        public SQLiteManage()
        {
            cnn= new SQLiteConnection("Data Source=database.db;Version=3;");
            cmd = new SQLiteCommand(cnn);
            cnn.Open();
            
            //tao cac bang
            cmd.CommandText = "CREATE TABLE if not exists Ex            (ID          TEXT PRIMARY KEY," +
                                                                        "Row1        TEXT," +
                                                                        "Row2        TEXT );";
            cmd.ExecuteNonQuery();
            cmd.CommandText +="CREATE TABLE if not exists ThingToDo     (ID          TEXT PRIMARY KEY," +
                                                                        "Name        TEXT," +
                                                                        "Type        INTERGER," +
                                                                        "Status      INTERGER," +
                                                                        "Stat        INTERGER," +
                                                                        "Score       INTERGER," +
                                                                        "ExID        TEXT," +
                                                                        "FOREIGN KEY(ExID) " +
                                                                        "REFERENCES Ex(ID) );";
            cmd.ExecuteNonQuery();
            cmd.CommandText +="CREATE TABLE if not exists Record       (ID          INTEGER PRIMARY KEY AUTOINCREMENT," +
                                                                       "TTDID       TEXT," +
                                                                       "TimeBegin   TEXT," +
                                                                       "Date        TEXT," +
                                                                       "Durations   TEXT," +
                                                                       "Note        TEXT," +
                                                                       "FOREIGN KEY(TTDID) " +
                                                                       "REFERENCES ThingToDo(ID) );";
            cmd.ExecuteNonQuery();
        }

        public void InsertToTable()
        {
             
        }
        public void LoadFromTable()
        {
           
        }
    }
}
