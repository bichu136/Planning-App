using System;
using System.Collections.Generic;
using System.Data;

namespace Do_An
{
    class ObjectiveData : ThingsToDoData
    {
        public ObjectiveData() : base()
        {
            
            cmd.Parameters.Add("$IntRow1",DbType.Int32);
            cmd.Parameters.Add("$TxtRow1",DbType.String);
            cmd.Parameters.Add("$Type",DbType.Int32);
        }
        public override void Close()
        {
            base.Close();
        }

        public override void Insert(string TableName, List<string> columns, List<string> values)
        {
            
            base.Insert(TableName, columns, values);
        }

        public override long Insert(object values)
        {
            Objective input = (Objective)values;
            cmd.CommandText = "insert into ThingToDo (Name,Status,lastupdate,IntRow1,TxtRow1,Type) values ($Name,$Status,$lastupdate,$IntRow1,$TxtRow1,$Type)";
            cmd.Parameters["$IntRow1"].Value = input.goal;
            cmd.Parameters["$TxtRow1"].Value = input.unit;
            cmd.Parameters["$Type"].Value = ThingsToDo.types.Objective;
            return base.Insert(values);
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
            Open();
            cmd.CommandText = "select ID,Name from ThingToDo where Type = $Type and (status != $Status)";
            cmd.Parameters.AddWithValue("$Type", (long)ThingsToDo.types.Objective);
            cmd.Parameters.AddWithValue("$Status", (long)ThingsToDo.statuses.Done);
            DataTable res = new DataTable();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            cnn.Close();
            return res;
        }
        public override void UpdateByDoing(string ID,long statuses)
        {
            RecordData rData = new RecordData();
            long Current=0;
            if (rData.CountOfCurrent(ID)>0)
                 Current = rData.SumOfCurrent(ID);
            if (Current > getGoal(ID))
            {
                base.UpdateByDoing(ID, statuses);
            }
        }
        public long getGoal(string ID)
        {
            cnn.Open();
            cmd.CommandText = "select IntRow1 from ThingToDo where ID=$ID";
            cmd.Parameters["$ID"].Value = ID;
            long x = (long)cmd.ExecuteScalar();
            cnn.Close();
            return x;
        }
        public void UpdateDone(string ID)
        {
            //cnn.Open();
            //cmd.CommandText = "update ThingToDo";
        }
        public string Unit(String ID)
        {
            //cmd.Reset();
            Open();
            cmd.CommandText = "select TxtRow1 from ThingToDo where ID = $ID";
            cmd.Parameters["$ID"].Value =  ID;
            string res = cmd.ExecuteScalar().ToString();
            cnn.Close();
            return res;
        }
    }
}