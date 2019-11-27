using System.Collections.Generic;
using System.Data;

namespace Do_An
{
    class TTDStatsData :SQLiteManage
    {
        public TTDStatsData():base()
        {
            cmd.Parameters.Add("$TTDID", DbType.String);
            cmd.Parameters.Add("$StatName", DbType.String);
            cmd.Parameters.Add("$Score", DbType.Int32);
        }

        public override void Close()
        {
            base.Close();
        }

        public override long Insert(object values)
        {
            cnn.Open();
            ThingsToDo input = (ThingsToDo)values;
            cmd.CommandText = "insert into TTD_Stats values($TTDID,$StatName,$Score)";
            cmd.Parameters["$TTDID"].Value = input.id;
            foreach(var x in input.score)
            {
                if (x.Value != 0)
                {
                    cmd.Parameters["$StatName"].Value = x.Key;
                    cmd.Parameters["$Score"].Value = x.Value;
                    cmd.ExecuteNonQuery();
                }
            }
            cnn.Close();
            return 0;
        }

        public override void Insert(string TableName, List<string> columns, List<string> values)
        {
            base.Insert(TableName, columns, values);
        }

        public override DataTable ReadDataTable()
        {
            return base.ReadDataTable();
        }
        public DataTable ReadScoreForTTD(string TTDID)
        {
            cnn.Open();
            cmd.CommandText = "select Stats.Name N,X.Score,Stats.ID from Stats left join (select TTD_Stats.StatsID,TTD_Stats.Score from TTD_Stats where TTDID = 0) X on(X.StatsID = Stats.ID)";
            cmd.Parameters["$TTDID"].Value = TTDID;
            DB.SelectCommand = cmd;
            DataTable res = new DataTable();
            DB.Fill(res);
            cnn.Close();
            return res;
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