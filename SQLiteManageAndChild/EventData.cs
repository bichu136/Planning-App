using System.Collections.Generic;
using System.Data;

namespace Do_An
{
    class EventData : ThingsToDoData
    {
        public override void Close()
        {
            base.Close();
        }

        public override void Insert(string TableName, List<string> columns, List<string> values)
        {
            //TODO: làm cho EventData;
            base.Insert(TableName, columns, values);
        }
        public string getNextEvent()
        {
            cnn.Open();
            cmd.CommandText = "select Name,TxtRow1 from ThingToDo where Type = 3 and date(TxtRow1) > date('now') order by date(TxtRow1) asc limit 1";
            reader = cmd.ExecuteReader();
            if (reader.HasRows == false)
            {
                reader.Close();
                cnn.Close();
                return "bạn chưa cần tham gia vào sự kiện nào gần đây";
            }
                
            reader.Read();
            string res = reader.GetString(0);
            reader.Close();
            cnn.Close();
            return res;
            
        }
        public override void Insert(object values)
        {
            Event input = (Event)values;
            cmd.CommandText = "insert into ThingToDo (Name,Status,lastupdate,TxtRow1,Type) values ($Name,$Status,$lastupdate,$TxtRow1,$Type)";
            cmd.Parameters.AddWithValue("$TxTRow1", input.beginTime.ToString("yyyy'-'MM'-'dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("$Type", ThingsToDo.types.Event);
            base.Insert(values);
        }

        public override DataTable ReadDataTable()
        {
            cnn.Open();
            cmd.CommandText = "select Name,Status,date(TxtRow1) ShowTime from ThingToDo where Type = '3'";
            DB.SelectCommand = cmd;
            DataTable dt = new DataTable();
            DB.Fill(dt);
            cnn.Close();
            return dt;
        }

        public override object[] ReadObject()
        {
            return base.ReadObject();
        }

        public override void StartReadFrom(string TableName, string[] columns)
        {
            base.StartReadFrom(TableName, columns);
        }
        public override void UpdateByDoing(string ID)
        {
            cnn.Open();
            cmd.CommandText = "update ThingToDo set Status = 0, lastupdate = datetime('now') where ID = $ID";
            cmd.Parameters.AddWithValue("$ID", ID);
            int x = cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public override DataTable ReadDataTableForDoing()
        {
            Open();
            cmd.CommandText = "select ID,Name from ThingToDo where Type = $Type and (status != $Status1)";
            cmd.Parameters.AddWithValue("$Type", (long)ThingsToDo.types.Event);
            cmd.Parameters.AddWithValue("$Status1", (long)ThingsToDo.statuses.Done);
            DataTable res = new DataTable();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            cnn.Close();
            return res;
        }
        public void UpdateForOngoing()
        {
            cnn.Open();
            DataTable res = new DataTable();
            cmd.CommandText = "update ThingToDo set Status = 1 where Type = $Type and date(TxtRow1) = date('now')";
            cmd.Parameters.AddWithValue("$Type", (int)ThingsToDo.types.Event);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}