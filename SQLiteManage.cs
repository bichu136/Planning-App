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
        public SQLiteDataReader reader;
        private List<ThingsToDo> Data;

        public SQLiteManage()
        {
            cnn = new SQLiteConnection("Data Source=database.db;Version=3;");
            cmd = new SQLiteCommand(cnn);
            cnn.Open();
            //bool flag;
            cmd.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='Type'";
            reader = cmd.ExecuteReader();
            if (reader.HasRows == false)
            {
                reader.Close();
                //tao cac bang nếu không có.
                cmd.CommandText = "CREATE TABLE if not exists Stats         (ID          INTEGER PRIMARY KEY," +
                                                                            "Name        TEXT," +
                                                                            "Description TEXT );";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE if not exists TTD_Stats     (TTDID       TEXT ," +
                                                                            "StatsID      INTEGER ," +
                                                                            "Score       INTEGER," +
                                                                            "primary key (TTDID,STatsID)" +
                                                                            "FOREIGN KEY (StatsID) references  Stats(ID), " +
                                                                            "Foreign key (TTDID)   references  ThingToDo(ID));";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE if not exists ThingToDo     (ID          TEXT PRIMARY KEY," +
                                                                            "Name        TEXT," +
                                                                            "Status      INTERGER," +
                                                                            "LastUpDate  TEXT," +
                                                                            "Type        INTEGER," +
                                                                            "TxtRow1     TEXT," +
                                                                            "TxtRow2     TEXT," +
                                                                            "TxtRow3     TEXT," +
                                                                            "TxtRow4     TEXT," +
                                                                            "TxtRow5     TEXT," +
                                                                            "IntRow1     INTEGER," +
                                                                            "IntRow2     INTEGER," +
                                                                            "IntRow3     INTEGER," +
                                                                            "IntRow4     INTEGER," +
                                                                            "IntRow5     INTEGER," +
                                                                            "FOREIGN KEY(Type) " +
                                                                            "REFERENCES Type(ID) );";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE if not exists Type          (ID          INTEGER PRIMARY KEY AUTOINCREMENT," +
                                                                            "Name        TEXT," +
                                                                            "TxtRows     Integer," +
                                                                            "IntRows     Integer);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE if not exists Record       (ID          INTEGER PRIMARY KEY AUTOINCREMENT," +
                                                                           "TTDID       TEXT," +
                                                                           "TimeBegin   TEXT," +
                                                                           "Date        TEXT," +
                                                                           "Durations   TEXT," +
                                                                           "Note        TEXT," +
                                                                           "FOREIGN KEY(TTDID) " +
                                                                           "REFERENCES ThingToDo(ID) );";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into Type (Name,TxtRows,IntRows) values (\"Objective\",0,2);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into Type (Name,TxtRows,IntRows) values (\"Daily\",0,1);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into Type (Name,TxtRows,IntRows) values (\"Event\",2,0);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into Type (Name,TxtRows,IntRows) values (\"Project\",1,0);";
                cmd.ExecuteNonQuery();
            }
            else
            {
                reader.Close();
            }
        }
        public object[] getTypes()
        {
            cmd.CommandText = "select * from Type";
            reader = cmd.ExecuteReader();
            List<String> a = new List<String>();
            while (reader.Read())
            {
                a.Add(reader.GetString(1));
            }
            string[] res = new string[a.Count];
            for (int i = 0; i < a.Count; i++)
            {
                res[i] = a[i];
            }
            reader.Close();
            return res;
        }
        public string[] getStatList()
        {
            cmd.CommandText = "select * from Stats";
            reader = cmd.ExecuteReader();
            List<String> a = new List<String>();
            while (reader.Read())
            {
                a.Add(reader.GetString(1));
            }
            string[] res = new string[a.Count];
            for (int i = 0; i < a.Count; i++)
            {
                res[i] = a[i];
            }
            reader.Close();
            return res;
        }
        public void Close()
        {
            //đóng kết nối 
            cnn.Close();
        }
        public void StartReadFrom(String TableName, string[] columns)
        {
            string buffer = "";
            for (int i = 0; i < columns.Length; i++)
            {
                buffer += columns[i];
                if (i + 1 < columns.Length) buffer += ",";
            }
            cmd.CommandText = "select " + buffer + " from Stats";
            reader = cmd.ExecuteReader();
        }
    }
}
