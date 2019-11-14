using System;
using System.Collections.Generic;
using System.Data;

namespace Do_An
{
    class ProjectData : ThingsToDoData
    {
        public ProjectData()
        {
            
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
        public override void Insert(string TableName, List<string> columns, List<string> values)
        {
            base.Insert(TableName, columns, values);
        }

        public override void Insert(object values)
        {
            Project input = (Project)values;
            //    List<string> columns = new List<string>() { "ID", "Name", "Status", "lastupdate", "TxtRow1", "Type" };
            //    List<string> values = new List<string>() { ID, Name, Status.ToString(), lastupdate.ToString("yyyy'-'MM'-'dd HH:mm:ss"), , type.ToString() };
            cmd.CommandText = "insert into ThingToDo (ID,Name,Status,lastupdate,TxtRow1,Type) values ($ID,$Name,$Status,$lastupdate,$TxtRow1,$Type)";
            cmd.Parameters.AddWithValue("$Type", ThingsToDo.types.Project);
            cmd.Parameters.AddWithValue("$TxtRow1", input.deadline.ToString("yyyy'-'MM'-'dd HH:mm:ss"));
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