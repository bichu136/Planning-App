
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Do_An
{
    class DailyData : ThingsToDoData
    {
        public DailyData():base()
        {
               
        }

        public override void Close()
        {
            base.Close();
        }

        public override void Insert(object values)
        {

            Daily Input = (Daily)values;
            cmd.CommandText = "insert into ThingToDo ( ID,Name,Status,lastupdate,IntRow1,Type) values( $ID,$Name,$Status,$lastupdate,$IntRow1,$Type)";
            cmd.Parameters.AddWithValue("$IntRow1", Input.Factor);
            cmd.Parameters.AddWithValue("$Type", ThingsToDo.types.Daily);
            base.Insert(values);
        }

        public override void Insert(string Table,List<string> columns, List<string> values)
        {
            base.Insert(Table,columns, values);
        }

        public override DataTable ReadDataTable()
        {
            cnn.Open();
            DataTable res= new DataTable();
            SQLiteCommand cmd= new SQLiteCommand("select ID,Name,Status from ThingToDo where Type = 1",cnn);
            this.DB.SelectCommand = cmd;
            DB.Fill(res);
            cnn.Close();
            return res;
        }
        public override void StartReadFrom(string TableName, string[] columns)
        {
            base.StartReadFrom(TableName, columns);
        }
        public override void UpdateStatusByID(string ID, ThingsToDo.statuses statuses)
        {
            
        }
    }
}