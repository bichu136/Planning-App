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

    }


}