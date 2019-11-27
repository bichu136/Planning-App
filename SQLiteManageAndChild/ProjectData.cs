using System;
using System.Collections.Generic;
using System.Data;

namespace Do_An
{
    class ProjectData : ThingsToDoData
    {
        public ProjectData():base()
        {
            cmd.Parameters.Add("$Type",DbType.Int32);
            cmd.Parameters.Add("$TxtRow1",DbType.String);
            cmd.Parameters.Add("$IntRow1",DbType.Int32);
        }

        public override void Close()
        {
            base.Close();
        }
        public String getNearestDeadline()
        {
            cnn.Open();
            cmd.CommandText = "select Name from ThingToDo where Type = 4 and date(TxtRow1) > date('now') order by date(TxtRow1) asc limit 1";
            reader = cmd.ExecuteReader();
            if (reader.HasRows == false)
            {
                reader.Close();
                cnn.Close();
                return "Hiện tại chưa có deadline nào.";
            }
                

            reader.Read();
            string res = reader.GetString(0);
            reader.Close();
            cnn.Close();
            return res;
        }

        public DataTable Read_OnGoingDataTable()
        {
            cnn.Open();
            cmd.CommandText = "Select Name,Status,datetime(TxtRow1) Deadline from ThingToDo Where Type = '4'";
            DB.SelectCommand = cmd;
            DataTable dt = new DataTable();
            DB.Fill(dt);
            cnn.Close();
            return dt;
        }

        public override void Insert(string TableName, List<string> columns, List<string> values)
        {
            base.Insert(TableName, columns, values);
        }

        public override long Insert(object values)
        {
            Project input = (Project)values;
            cmd.CommandText = "insert into ThingToDo (Name,Status,lastupdate,TxtRow1,Type,IntRow1) values ($Name,$Status,$lastupdate,$TxtRow1,$Type,$IntRow1)";
            cmd.Parameters["$Type"].Value = (int)ThingsToDo.types.Project;
            cmd.Parameters["$TxtRow1"].Value = input.deadline.ToString("yyyy'-'MM'-'dd HH:mm:ss");
            cmd.Parameters["$IntRow1"].Value =  input.HasPlan;
            return base.Insert(values);
        }

        public override DataTable ReadDataTable()
        {
            cnn.Open();
            cmd.CommandText = "Select Name,Status,datetime(TxtRow1) Deadline from ThingToDo Where Type = '4'";
            DB.SelectCommand = cmd;
            DataTable dt = new DataTable();
            DB.Fill(dt);
            cnn.Close();
            return dt;

        }

        public bool isCheck(string ID)
        {
            Open();
            cmd.CommandText = "select IntRow1 from ThingToDo where ID= $ID";
            cmd.Parameters.AddWithValue("$ID",ID);
            int res = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            cnn.Close();
            return res!=0;
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
            cmd.Parameters["$Type"].Value =  (long)ThingsToDo.types.Project;
            cmd.Parameters["$Status"].Value = (long)ThingsToDo.statuses.Done;
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
            if (rData.CountOfCurrent(ID) > 0)
            {
                 Current = rData.SumOfCurrent(ID);
            }
            

            if (Current >= 100) 
            {
                base.UpdateByDoing(ID,statuses);
            }
        }
        public void UpdateForDropped()
        {
            cnn.Open();
            DataTable res = new DataTable();
            cmd.CommandText = "update ThingToDo set Status = -1 where Type = $Type and date(TxtRow1) = date('now')";
            cmd.Parameters["$Type"].Value = (int)ThingsToDo.types.Project;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}