using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An
{
    class StatusData : SQLiteManage
    {
        public StatusData()
        {
        }

        public override DataTable ReadDataTable()
        {
            cnn.Open();
            cmd.CommandText = "select ID,Name from Status";
            DataTable res = new DataTable();
            DB.SelectCommand = cmd;
            DB.Fill(res);
            cnn.Close();
            return res;
        }
        public DataTable ReadDataTableForDaily()
        {
            cnn.Open();
            cmd.CommandText = "select ID,Name from Status where ID = 0 or ID = 1";
            DataTable dt = new DataTable();
            DB.SelectCommand = cmd;
            DB.Fill(dt);
            cnn.Close();
            return dt;
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
