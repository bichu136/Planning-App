using System.Collections.Generic;
using System.Data;

namespace Do_An
{
    class TTDStatsData :SQLiteManage
    {
        public TTDStatsData()
        {
            cmd = new System.Data.SQLite.SQLiteCommand(cnn);
        }

        public override void Close()
        {
            base.Close();
        }

        public override void Insert(object values)
        {
            cnn.Open();
            ThingsToDo input = (ThingsToDo)values;
            cmd.CommandText = "insert into TTD_Stats values($TTDID,$StatName,$Score)";
            cmd.Parameters.Add("$TTDID", DbType.String);
            cmd.Parameters.Add("$StatName", DbType.String);
            cmd.Parameters.Add("$Score", DbType.Int32);
            cmd.Parameters[0].Value = input.id;
            foreach(var x in input.score)
            {
                if (x.Value != 0)
                {
                    cmd.Parameters[1].Value = x.Key;
                    cmd.Parameters[2].Value = x.Value;
                    cmd.ExecuteNonQuery();
                }
            }
            cnn.Close();

        }

        public override void Insert(string TableName, List<string> columns, List<string> values)
        {
            base.Insert(TableName, columns, values);
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