using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Do_An
{
    class ThingsToDoData : SQLiteManage
    {
        public ThingsToDoData()
        {            
        }
        public override void Close()
        {
            base.Close();
        }

        public override void Insert(object values)
        {
            cnn.Open();
            ThingsToDo Input = (ThingsToDo)values;
            cmd.Parameters.AddWithValue("$Name", Input.name);
            cmd.Parameters.AddWithValue("$Status", Input.status);
            cmd.Parameters.AddWithValue("$lastupdate", Input.lastUpDate.ToString("yyyy'-'MM'-'dd HH:mm:ss"));
            cmd.ExecuteNonQuery();
            cnn.Close();
            //Program.manager.InsertTo();
        }
        public virtual void UpdateStatusByID(string ID, long statuses)
        {
            cnn.Open();
            cmd.CommandText = "update ThingToDo set Status = $status where ID = $ID;";
            cmd.Parameters.AddWithValue("$status",statuses);
            cmd.Parameters.AddWithValue("$ID", ID);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void UpdateWhenDoingSomethingByID(int ID)
        {
            cnn.Open();
            cmd.CommandText = "Update ThingsToDo set lastupdate= $lastupdate where ID=$ID";
            cmd.Parameters.AddWithValue("$ID", ID);
            cmd.Parameters.AddWithValue("$ID", DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss"));
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public DataTable ReadDataTableWithType(long Type)
        {
            cnn.Open();
            DataTable dt= new DataTable();
            cmd.CommandText = "select ID,Name from ThingToDo where Type = $Type and (status = $status1 or status = $status2)";
            cmd.Parameters.AddWithValue("$Type", Type);
            cmd.Parameters.AddWithValue("$status1", (int)ThingsToDo.statuses.Ongoing);
            cmd.Parameters.AddWithValue("$status2", (int)ThingsToDo.statuses.Dropped);
            DB.SelectCommand = cmd;
            DB.Fill(dt);
            cnn.Close();
            return dt;
        }
        public void UpdateDropStatus()
        {
            cnn.Open();
            cmd.CommandText = "Update ThingsToDo set status = $status where date(lastupdate,'+1 month') < date('now')";
            cmd.Parameters.AddWithValue("$Status", ThingsToDo.statuses.Dropped);
            cnn.Close();
        }
        public virtual void UpdateByDoing(string ID)
        {

        }

        public virtual DataTable ReadDataTableForDoing()
        {
            return null;
        }
    }

}