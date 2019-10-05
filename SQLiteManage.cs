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
        private SQLiteDataReader reader;
        private List<Jobs> Data;
        public enum Table{ Record = 1,ThingToDo = 0,Ex = 1};
        public SQLiteManage()
        {
            cnn= new SQLiteConnection("Data Source=database.db;Version=3;");
            cmd = new SQLiteCommand(cnn);
            cnn.Open();
            
            //tao cac bang nếu không có.
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
                                                                        "LastUpDate  TEXT,"+
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
        public void InsertToEx(String ID,String r1,String r2)
        {
            cmd.CommandText = "insert into Ex (ID,Row1,Row2) Values (\""+ ID + "\",\"" + r1 + "\",\"" + r2+"\")";
            cmd.ExecuteNonQuery();       
        }
        public void InsertToTTD(String ID,String Name, int Type,int Status,int Stat,int Score, String ExID, String row1, String row2)
        {
            InsertToEx(ExID, row1, row2);
            cmd.CommandText = "insert into ThingToDo (ID,Name,Type,Status,Stat,Score,LastUpDate) Values (\"" + ID + "\",\"" + Name + "\"," + Type + "," + Status + "," + Stat + ","+Score+",\""+DateTime.Now.ToString()+"\")";
            cmd.ExecuteNonQuery();
        }
        public void InsertToRecord(String TTDID,String TimeBegin,String Date,String Duration,String Note)
        {
            cmd.CommandText = "insert into Record (TTDID,TimeBegin,Date,Durations,Note) Values (\"" + TTDID + "\",\"" + TimeBegin + "\",\"" + Date + "\",\"" +Duration + "\",\""+Note+"\")";
            cmd.ExecuteNonQuery();
        }
        public String LoadFromTable()
        {
            //thực hiện lệnh
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from ThingToDo";
            reader = cmd.ExecuteReader();
            //bắt đầu đọc 
            reader.Read();
            String res = reader.GetTextReader(0).ReadToEnd();
            res += " " + reader.GetInt32(3);
            reader.Close();
            return res;
        }
        public void Close()
        {
            //đóng kết nối 
            cnn.Close();
        }
    }
}
