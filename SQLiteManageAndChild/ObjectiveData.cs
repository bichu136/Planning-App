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
            cmd.CommandText = "insert into ThingToDo (ID,Name,Status,lastupdate,IntRow1,IntRow2,Type) values ($ID,$Name,$Status,$lastupdate,$IntRow1,$IntRow2,$Type)";
            cmd.Parameters.AddWithValue("$IntRow1", input.current);
            cmd.Parameters.AddWithValue("$IntRow2", input.goal);
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
    }
}