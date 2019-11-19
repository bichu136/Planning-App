using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Do_An 
{
    class SQLiteManage 
    {
        protected SQLiteConnection cnn;
        protected SQLiteCommand cmd;
        protected SQLiteDataAdapter DB;
        protected SQLiteDataReader reader;
        //protected List<ThingsToDo> Data;

        public SQLiteDataReader reader1 { get => reader;}

        public SQLiteManage()
        {
            cnn = new SQLiteConnection("Data Source=database.db;Version=3;");
            cmd = new SQLiteCommand(cnn);
            DB = new SQLiteDataAdapter();
        }
        public void Open()
        {
            if(cnn.State != ConnectionState.Open)
            {

            }
        }
        #region Override method
        public virtual void Close()
        {
            //đóng kết nối 
            cnn.Close();
        }
        public virtual void StartReadFrom(String TableName, string[] columns)
        {
            cnn.Open();
            string buffer = "";
            for (int i = 0; i < columns.Length; i++)
            {
                buffer += columns[i];
                if (i + 1 < columns.Length) buffer += ",";
            }
            cmd.CommandText = "select " + buffer + " from " + TableName;
            reader = cmd.ExecuteReader();
        }
        public virtual void Insert(object values)
        {
            if (cmd.Parameters.Count == 0) throw new InvalidOperationException();
            
        }
        public virtual void Insert(String TableName, List<string> columns, List<string> values)
        {
            string column="";
            string value="";
            for (int i = 0; i < columns.Count; i++)
            {
                column += columns[i];
                value += "'" + values[i] + "'";
                if (i + 1 < columns.Count) { column += ","; value += ","; }
            }
            cmd.CommandText = "insert into " + TableName + " ("+column+") values (" +value+")";
            cmd.ExecuteNonQuery();
            //throw new InvalidOperationException();
        }
        public virtual object[] ReadObject()
        {
            return null;
        }
        public virtual DataTable ReadDataTable()
        {
            return null;
        }
        public void CreateDatabase()
        {
             cnn.Open();
            //bool flag;
            cmd.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='Type'";
            reader = cmd.ExecuteReader();
            if (reader.HasRows == false)
            {
                reader.Close();
                //tao cac bang nếu không có.
                cmd.CommandText = "CREATE TABLE if not exists Stats         (Name        TEXT PRIMARY key," +
                                                                            "Description TEXT );";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE if not exists TTD_Stats     (TTDID       TEXT ," +
                                                                            "StatsName   TEXT ," +
                                                                            "Score       INTEGER," +
                                                                            "primary key (TTDID,StatsName)" +
                                                                            "FOREIGN KEY (StatsName) references  Stats(Name), " +
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

            cnn.Close();
        }
        #endregion
    }
}
