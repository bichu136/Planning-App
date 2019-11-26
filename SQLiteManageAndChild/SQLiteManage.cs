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
            throw new NotImplementedException();
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
                cmd.CommandText = "CREATE TABLE if not exists Stats         (Name        TEXT," +
                                                                            "ID          integer PRIMARY key autoincrement," +
                                                                            "Description TEXT );";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE if not exists TTD_Stats     (TTDID       TEXT ," +
                                                                            "StatsID   integer ," +
                                                                            "Score       INTEGER," +
                                                                            "primary key (TTDID,StatsID)" +
                                                                            "FOREIGN KEY (StatsID) references  Stats(ID), " +
                                                                            "Foreign key (TTDID)   references  ThingToDo(ID));";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE if not exists Status       (ID          INTEGER PRIMARY KEY AUTOINCREMENT," +
                                                                           "Name        Text);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE if not exists ThingToDo     (ID          integer PRIMARY KEY autoincrement," +
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
                                                                            "FloatRow1   REAL," +
                                                                            "FloatRow2   REAL," +
                                                                            "FOREIGN KEY(Type) " +
                                                                            "REFERENCES Type(ID) );";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE if not exists Type          (ID          INTEGER PRIMARY KEY AUTOINCREMENT," +
                                                                            "Name        TEXT," +
                                                                            "TxtRows     Integer," +
                                                                            "IntRows     Integer);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE if not exists Record       (ID          INTEGER PRIMARY KEY AUTOINCREMENT," +
                                                                           "TTDID       integer," +
                                                                           "Date        TEXT," +
                                                                           "Current     Integer," +
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
                cmd.CommandText = "insert into Status (ID,Name) values ($ID,$Name)";
                cmd.Parameters.Add("$ID", DbType.Int32);
                cmd.Parameters.Add("$Name", DbType.String);
                cmd.Parameters["$ID"].Value = (Int32)ThingsToDo.statuses.Done;
                cmd.Parameters["$Name"].Value = ThingsToDo.statuses.Done.ToString();
                cmd.ExecuteNonQuery();
                cmd.Parameters["$ID"].Value = (Int32)ThingsToDo.statuses.Dropped;
                cmd.Parameters["$Name"].Value = ThingsToDo.statuses.Dropped.ToString();
                cmd.ExecuteNonQuery();
                cmd.Parameters["$ID"].Value = (Int32)ThingsToDo.statuses.Missed;
                cmd.Parameters["$Name"].Value = ThingsToDo.statuses.Missed.ToString();
                cmd.ExecuteNonQuery();
                cmd.Parameters["$ID"].Value = (Int32)ThingsToDo.statuses.Ongoing;
                cmd.Parameters["$Name"].Value = ThingsToDo.statuses.Ongoing.ToString();
                cmd.ExecuteNonQuery();
                cmd.Parameters["$ID"].Value = (Int32)ThingsToDo.statuses.Waiting;
                cmd.Parameters["$Name"].Value = ThingsToDo.statuses.Waiting.ToString();
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
