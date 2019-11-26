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
        public RecordData()
        {
            
        }

        public override void Insert(object values)
        {
            Record input = (Record)values;
            cnn.Open();
            cmd.CommandText = "insert into Record (TTDID,Date,Current,Note)values($TTDID,$Date,$Current,$Note)";
            cmd.Parameters.AddWithValue("$TTDID",input.TTD_ID);
            cmd.Parameters.AddWithValue("$Current", input.TTD_ID);
            cmd.Parameters.AddWithValue("$Note","");
            cnn.Close();
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
    }
}
