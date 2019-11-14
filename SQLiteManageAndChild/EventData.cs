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
            cmd.CommandText = "insert into ThingToDo (ID,Name,Status,lastupdate,TxtRow1,Type) values ($ID,$Name,$Status,$lastupdate,$TxtRow1,$Type)";
            cmd.Parameters.AddWithValue("$TxTRow1", input.beginTime.ToString("yyyy'-'MM'-'dd HH:mm:ss"));
            cmd.Parameters.AddWithValue("$Type", ThingsToDo.types.Event);
            base.Insert(values);
        }

        public override DataTable ReadDataTable()
        {
            return base.ReadDataTable();
        }

        public override object[] ReadObject()
        {
            return base.ReadObject();
        }

        public override void StartReadFrom(string TableName, string[] columns)
        {
            base.StartReadFrom(TableName, columns);
        }
    }
}