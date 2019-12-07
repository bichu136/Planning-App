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
    }
}
