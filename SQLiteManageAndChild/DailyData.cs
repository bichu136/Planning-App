
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Do_An
{
    class DailyData : ThingsToDoData
    {
        public DailyData():base()
        {
            cmd.Parameters.Add("$IntRow1",DbType.Int32);
            cmd.Parameters.Add("$IntRow2",DbType.Int32);
            cmd.Parameters.Add("$Type",DbType.Int32);
        }

        public override void Close()
        {
            base.Close();
        }

        public override long Insert(object values)
        {

            Daily Input = (Daily)values;
            cmd.CommandText = "insert into ThingToDo (Name,Status,lastupdate,IntRow1,IntRow2,Type) values($Name,$Status,$lastupdate,$IntRow1,$IntRow2,$Type)";
            cmd.Parameters["$IntRow1"].Value = Input.Factor;
            cmd.Parameters["$IntRow2"].Value = Input.WeekDayToDo;
            cmd.Parameters["$Type"].Value = (int)ThingsToDo.types.Daily;
            return base.Insert(values);
        }
        public override void Insert(string Table,List<string> columns, List<string> values)
        {
            base.Insert(Table,columns, values);
        }

        public void UpdateNewDay()
        {
            cnn.Open();
            cmd.CommandText = "update ThingToDo set Status = 1 where Type = 2 and Status != -1 and date(lastupdate) < date('now') and (IntRow1 = $IntRow1 or IntRow1 =7)";
            cmd.Parameters["$IntRow1"].Value= (long)DateTime.Now.DayOfWeek;
            int x = cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public override DataTable ReadDataTable()
        {
            cnn.Open();
            DataTable res= new DataTable();
            cmd.CommandText= "select ThingToDo.ID,ThingToDo.Name,Status.Name,ThingToDo.Status from ThingToDo inner join Status On(ThingToDo.Status=Status.ID) where Type = 2 and (IntRow1 = $IntRow1 or IntRow1 =7)";
            cmd.Parameters["$IntRow1"].Value =(long)DateTime.Now.DayOfWeek;
            this.DB.SelectCommand = cmd;
            DB.Fill(res);
            cnn.Close();
            return res;
        }
        public override void StartReadFrom(string TableName, string[] columns)
        {
            base.StartReadFrom(TableName, columns);
        }
        public override void UpdateStatusByID(string ID, long statuses)
        {
            base.UpdateByDoing(ID,statuses);
        }
        public override DataTable ReadDataTableForDoing()
        {
            Open();
            cmd.CommandText = "select ID,Name from ThingToDo where Type = $Type and (status != $Status)";
            cmd.Parameters["$Type"].Value =  (long)ThingsToDo.types.Daily;
            cmd.Parameters["$Status"].Value = (long)ThingsToDo.statuses.Done;
            DataTable res = new DataTable();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            cnn.Close();
            return res;
        }
        public override void UpdateByDoing(string ID,long statuses)
        {
            cnn.Open();
            cmd.CommandText = "update ThingToDo set Status = 0, lastupdate = datetime('now') where ID = $ID";
            cmd.Parameters["$ID"].Value =  ID;
            int x = cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}