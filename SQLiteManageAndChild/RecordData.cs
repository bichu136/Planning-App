using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An
{
    class RecordData : SQLiteManage
    {
        public RecordData():base()
        {
            cmd.Parameters.Add("$TTDID", DbType.Int32);
            cmd.Parameters.Add("$Current", DbType.Int32);
            cmd.Parameters.Add("$Note", DbType.String);
            cmd.Parameters.Add("$Date", DbType.String);
        }

        public override long Insert(object values)
        {
            Record input = (Record)values;
            cnn.Open();
            cmd.CommandText = "insert into Record (TTDID,Date,Current,Note)values($TTDID,$Date,$Current,$Note)";
            cmd.Parameters["$TTDID"].Value = input.TTD_ID;
            cmd.Parameters["$Current"].Value = input.Current;
            cmd.Parameters["$Date"].Value = input.Date.ToString("yyyy'-'MM'-'dd HH:mm:ss");
            cmd.Parameters["$Note"].Value = "";
            cmd.ExecuteNonQuery();
            cnn.Close();
            return 0;
        }

        public override void Insert(string TableName, List<string> columns, List<string> values)
        {
            base.Insert(TableName, columns, values);
        }

        public override DataTable ReadDataTable()
        {
            cnn.Open();

            cmd.CommandText = "select TTDID,Date,Current,Note in Record";
            DB.SelectCommand = cmd;
            DataTable res = new DataTable();
            DB.Fill(res);
            cnn.Close();
            return res;
        }
        public Dictionary<long,int> GetScoreByType()
        {
            return null;
        }

        public override object[] ReadObject()
        {
            return base.ReadObject();
        }
        public long SumOfCurrent(string ID)
        {
            Open();
            cmd.CommandText = "select sum(Record.Current) from record where TTDID = $TTDID group by TTDID";
            cmd.Parameters["$TTDID"].Value = ID;
            object t = cmd.ExecuteScalar();
            long x = (t==null)? 0 : (long)t;
            cnn.Close();
            return x;
            
        }
        public long CountOfCurrent(string ID)
        {
            Open();
            cmd.CommandText = "select count(Record.TTDID) from record where TTDID = $TTDID group by TTDID";
            cmd.Parameters["$TTDID"].Value = ID;
            object t = cmd.ExecuteScalar();
            string x = (t == null)? "0": t.ToString();
            long z = Int64.Parse(x);
            cnn.Close();
            return z;
        }
        #region ALLSCORE
        public DataTable GetDailyScores()
        {
            cmd.CommandText = "select Stats.Name,temp2.x,Stats.ID from Stats left join(select TTD_Stats.StatsID,sum(TTD_Stats.Score * (temp.result1)*1.0) x from TTD_Stats,(select count(Record.Current) result1,Record.TTDID from Record,ThingToDo where ThingToDo.ID = Record.TTDID and ThingToDo.Type = 2 group by TTDID) temp where temp.TTDID = TTD_Stats.TTDID group by TTD_Stats.StatsID) temp2 on Stats.ID = temp2.StatsID";
            DataTable res = new DataTable();
            Open();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            for (int i = 0; i < res.Rows.Count; i++)
            {
                res.Rows[i]["x"] = (res.Rows[i]["x"].ToString() == "") ? 0.0 : res.Rows[i]["x"];
            }
            cnn.Close();
            return res;
        }
        public DataTable GetEventScores()
        {
            cmd.CommandText = "select Stats.Name,temp2.x,Stats.ID from Stats left join(select TTD_Stats.StatsID,sum(TTD_Stats.Score * (temp.result1)) x from TTD_Stats,(select count(Record.Current) result1,Record.TTDID from Record,ThingToDo where ThingToDo.ID = Record.TTDID and ThingToDo.Type = 3   group by TTDID) temp where temp.TTDID = TTD_Stats.TTDID group by TTD_Stats.StatsID) temp2 on Stats.ID = temp2.StatsID";
            DataTable res = new DataTable();
            Open();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            for (int i = 0; i < res.Rows.Count; i++)
            {
                res.Rows[i]["x"] = (res.Rows[i]["x"].ToString() == "") ? 0.0 : res.Rows[i]["x"];
            }
            cnn.Close();
            return res;
        }
        public DataTable GetObjectScores()
        {
            cmd.CommandText = "select Stats.Name,temp2.x,Stats.ID from Stats left join(select TTD_Stats.StatsID,sum(TTD_Stats.Score * (temp.result1)) x from TTD_Stats,(select sum(Record.Current / (1.0 * ThingToDo.IntRow1)) result1,Record.TTDID from Record,ThingToDo where ThingToDo.ID = Record.TTDID and ThingToDo.Type = 1   group by TTDID) temp where temp.TTDID = TTD_Stats.TTDID group by TTD_Stats.StatsID) temp2 on Stats.ID = temp2.StatsID ";
            DataTable res = new DataTable();
            Open();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            for (int i = 0; i < res.Rows.Count; i++)
            {
                res.Rows[i]["x"] = (res.Rows[i]["x"].ToString() == "") ? 0.0 : res.Rows[i]["x"];
            }
            cnn.Close();
            return res;
        }
        public DataTable GetProjectScores()
        {
            cmd.CommandText = "select Stats.Name,temp2.x,Stats.ID from Stats left join ( select TTD_Stats.StatsID,sum(TTD_Stats.Score * (temp.result1 / 100.0)) x from TTD_Stats,(select sum(Record.Current) result1,Record.TTDID from Record,ThingToDo where ThingToDo.ID = Record.TTDID and ThingToDo.Type = 4   group by TTDID) temp where temp.TTDID = TTD_Stats.TTDID group by TTD_Stats.StatsID) temp2 on Stats.ID = temp2.StatsID";
            DataTable res = new DataTable();
            Open();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            for (int i= 0;i < res.Rows.Count;i++)
            {
                res.Rows[i]["x"] = (res.Rows[i]["x"].ToString() == "") ? 0.0 : res.Rows[i]["x"];
            }
            cnn.Close();
            return res;
        }
        #endregion
        #region Weekly
        public DataTable GetDailyScoresWeekly()
        {
            cmd.CommandText = "select Stats.Name,temp2.x,Stats.ID from Stats left join(select TTD_Stats.StatsID,sum(TTD_Stats.Score * (temp.result1)*1.0) x from TTD_Stats,(select count(Record.Current) result1,Record.TTDID from Record,ThingToDo where ThingToDo.ID = Record.TTDID and ThingToDo.Type = 2 and strftime('%W',Record.Date) = strftime('%W','now','localtime') group by TTDID) temp where temp.TTDID = TTD_Stats.TTDID group by TTD_Stats.StatsID) temp2 on Stats.ID = temp2.StatsID";
            DataTable res = new DataTable();
            Open();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            for (int i = 0; i < res.Rows.Count; i++)
            {
                res.Rows[i]["x"] = (res.Rows[i]["x"].ToString() == "") ? 0.0 : res.Rows[i]["x"];
            }
            cnn.Close();
            return res;
        }
        public DataTable GetEventScoresWeekly()
        {
            cmd.CommandText = "select Stats.Name,temp2.x,Stats.ID from Stats left join(select TTD_Stats.StatsID,sum(TTD_Stats.Score * (temp.result1)) x from TTD_Stats,(select count(Record.Current) result1,Record.TTDID from Record,ThingToDo where ThingToDo.ID = Record.TTDID and ThingToDo.Type = 3 and strftime('%W',Record.Date) = strftime('%W','now','localtime') group by TTDID) temp where temp.TTDID = TTD_Stats.TTDID group by TTD_Stats.StatsID) temp2 on Stats.ID = temp2.StatsID";
            DataTable res = new DataTable();
            Open();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            for (int i = 0; i < res.Rows.Count; i++)
            {
                res.Rows[i]["x"] = (res.Rows[i]["x"].ToString() == "") ? 0.0 : res.Rows[i]["x"];
            }
            cnn.Close();
            return res;
        }
        public DataTable GetObjectScoresWeekly()
        {
            cmd.CommandText = "select Stats.Name,temp2.x,Stats.ID from Stats left join(select TTD_Stats.StatsID,sum(TTD_Stats.Score * (temp.result1)) x from TTD_Stats,(select sum(Record.Current / (1.0 * ThingToDo.IntRow1)) result1,Record.TTDID from Record,ThingToDo where ThingToDo.ID = Record.TTDID and ThingToDo.Type = 1 and strftime('%W',Record.Date) = strftime('%W','now','localtime') group by TTDID) temp where temp.TTDID = TTD_Stats.TTDID group by TTD_Stats.StatsID) temp2 on Stats.ID = temp2.StatsID ";
            DataTable res = new DataTable();
            Open();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            for (int i = 0; i < res.Rows.Count; i++)
            {
                res.Rows[i]["x"] = (res.Rows[i]["x"].ToString() == "") ? 0.0 : res.Rows[i]["x"];
            }
            cnn.Close();
            return res;
        }
        public DataTable GetProjectScoresWeekly()
        {
            cmd.CommandText = "select Stats.Name,temp2.x,Stats.ID from Stats left join ( select TTD_Stats.StatsID,sum(TTD_Stats.Score * (temp.result1 / 100.0)) x from TTD_Stats,(select sum(Record.Current) result1,Record.TTDID from Record,ThingToDo where ThingToDo.ID = Record.TTDID and ThingToDo.Type = 4 and strftime('%m',Record.Date) = strftime('%m','now','localtime') group by TTDID) temp where temp.TTDID = TTD_Stats.TTDID group by TTD_Stats.StatsID) temp2 on Stats.ID = temp2.StatsID";
            DataTable res = new DataTable();
            Open();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            for (int i = 0; i < res.Rows.Count; i++)
            {
                res.Rows[i]["x"] = (res.Rows[i]["x"].ToString() == "") ? 0.0 : res.Rows[i]["x"];
            }
            cnn.Close();
            return res;
        }
        #endregion 
        public DataTable GetDailyScoresMonthly()
        {
            cmd.CommandText = "select Stats.Name,temp2.x,Stats.ID from Stats left join(select TTD_Stats.StatsID,sum(TTD_Stats.Score * (temp.result1)*1.0) x from TTD_Stats,(select count(Record.Current) result1,Record.TTDID from Record,ThingToDo where ThingToDo.ID = Record.TTDID and ThingToDo.Type = 2 and strftime('%m',Record.Date) = strftime('%m','now','localtime') group by TTDID) temp where temp.TTDID = TTD_Stats.TTDID group by TTD_Stats.StatsID) temp2 on Stats.ID = temp2.StatsID";
            DataTable res = new DataTable();
            Open();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            for (int i = 0; i < res.Rows.Count; i++)
            {
                res.Rows[i]["x"] = (res.Rows[i]["x"].ToString() == "") ? 0.0 : res.Rows[i]["x"];
            }
            cnn.Close();
            return res;
        }
        public DataTable GetEventScoresMonthly()
        {
            cmd.CommandText = "select Stats.Name,temp2.x,Stats.ID from Stats left join(select TTD_Stats.StatsID,sum(TTD_Stats.Score * (temp.result1)) x from TTD_Stats,(select count(Record.Current) result1,Record.TTDID from Record,ThingToDo where ThingToDo.ID = Record.TTDID and ThingToDo.Type = 3 and strftime('%m',Record.Date) = strftime('%m','now','localtime') group by TTDID) temp where temp.TTDID = TTD_Stats.TTDID group by TTD_Stats.StatsID) temp2 on Stats.ID = temp2.StatsID";
            DataTable res = new DataTable();
            Open();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            for (int i = 0; i < res.Rows.Count; i++)
            {
                res.Rows[i]["x"] = (res.Rows[i]["x"].ToString() == "") ? 0.0 : res.Rows[i]["x"];
            }
            cnn.Close();
            return res;
        }
        public DataTable GetObjectScoresMonthly()
        {
            cmd.CommandText = "select Stats.Name,temp2.x,Stats.ID from Stats left join(select TTD_Stats.StatsID,sum(TTD_Stats.Score * (temp.result1)) x from TTD_Stats,(select sum(Record.Current / (1.0 * ThingToDo.IntRow1)) result1,Record.TTDID from Record,ThingToDo where ThingToDo.ID = Record.TTDID and ThingToDo.Type = 1 and strftime('%m',Record.Date) = strftime('%m','now','localtime') group by TTDID) temp where temp.TTDID = TTD_Stats.TTDID group by TTD_Stats.StatsID) temp2 on Stats.ID = temp2.StatsID ";
            DataTable res = new DataTable();
            Open();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            for (int i = 0; i < res.Rows.Count; i++)
            {
                res.Rows[i]["x"] = (res.Rows[i]["x"].ToString() == "") ? 0.0 : res.Rows[i]["x"];
            }
            cnn.Close();
            return res;
        }
        public DataTable GetProjectScoresMonthly()
        {
            cmd.CommandText = "select Stats.Name,temp2.x,Stats.ID from Stats left join ( select TTD_Stats.StatsID,sum(TTD_Stats.Score * (temp.result1 / 100.0)) x from TTD_Stats,(select sum(Record.Current) result1,Record.TTDID from Record,ThingToDo where ThingToDo.ID = Record.TTDID and ThingToDo.Type = 4 and strftime('%m',Record.Date) = strftime('%m','now','localtime') group by TTDID) temp where temp.TTDID = TTD_Stats.TTDID group by TTD_Stats.StatsID) temp2 on Stats.ID = temp2.StatsID";
            DataTable res = new DataTable();
            Open();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            for (int i = 0; i < res.Rows.Count; i++)
            {
                res.Rows[i]["x"] = (res.Rows[i]["x"].ToString() == "") ? 0.0 : res.Rows[i]["x"];
            }
            cnn.Close();
            return res;
        }
        public DataTable GetAllScores()
        {
            DataTable Sum = GetDailyScores();
            DataTable Obj = GetObjectScores();
            DataTable Prj = GetProjectScores();
            DataTable Evn = GetEventScores();
            for (int i = 0; i<Sum.Rows.Count;i++)
            {
                double D,O, P, E;
                O = Obj.Rows[i].Field<double>("x");
                P = Prj.Rows[i].Field<double>("x");
                E = Evn.Rows[i].Field<double>("x");
                D = Sum.Rows[i].Field<double>("x");
                Sum.Rows[i]["x"] =D + O + P + E;
            }
            return Sum;
        }
        public DataTable GetAllScoresWeekly()
        {
            DataTable Sum = GetDailyScoresWeekly();
            DataTable Obj = GetObjectScoresWeekly();
            DataTable Prj = GetProjectScoresWeekly();
            DataTable Evn = GetEventScoresWeekly();
            for (int i = 0; i < Sum.Rows.Count; i++)
            {
                double D, O, P, E;
                O = Obj.Rows[i].Field<double>("x");
                P = Prj.Rows[i].Field<double>("x");
                E = Evn.Rows[i].Field<double>("x");
                D = Sum.Rows[i].Field<double>("x");
                Sum.Rows[i]["x"] = D + O + P + E;
            }
            return Sum;
        }
        internal DataTable GetAllScoresMonthly()
        {
            DataTable Sum = GetDailyScoresMonthly();
            DataTable Obj = GetObjectScoresMonthly();
            DataTable Prj = GetProjectScoresMonthly();
            DataTable Evn = GetEventScoresMonthly();
            for (int i = 0; i < Sum.Rows.Count; i++)
            {
                double D, O, P, E;
                O = Obj.Rows[i].Field<double>("x");
                P = Prj.Rows[i].Field<double>("x");
                E = Evn.Rows[i].Field<double>("x");
                D = Sum.Rows[i].Field<double>("x");
                Sum.Rows[i]["x"] = D + O + P + E;
            }
            return Sum;
        }
    }
}
