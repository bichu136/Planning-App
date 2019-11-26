using System.Collections.Generic;
using System.Data;

namespace Do_An
{
    class ObjectiveData : ThingsToDoData
    {
        public override void Close()
        {
            base.Close();
        }

        public override void Insert(string TableName, List<string> columns, List<string> values)
        {
            
            base.Insert(TableName, columns, values);
        }

        public override void Insert(object values)
        {
            Objective input = (Objective)values;
            cmd.CommandText = "insert into ThingToDo (Name,Status,lastupdate,IntRow1,TxtRow1,Type) values ($Name,$Status,$lastupdate,$IntRow1,$TxtRow1,$Type)";
            cmd.Parameters.AddWithValue("$IntRow1", input.goal);
            cmd.Parameters.AddWithValue("$TxtRow1", input.unit);
            cmd.Parameters.AddWithValue("$Type", ThingsToDo.types.Objective);
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
        public override DataTable ReadDataTableForDoing()
        {
            DataTable res = new DataTable();
            return res;
        }
        public override void UpdateByDoing(string ID)
        {
            cnn.Open();
            cmd.CommandText = "update ThingToDo set lastupdate = datetime('now') where ID = $ID";
            cmd.Parameters.AddWithValue("$ID", ID);
            int x = cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void UpdateDone(string ID)
        {
            cnn.Open();
            cmd.CommandText = "update ThingToDo";
        }
    }
}