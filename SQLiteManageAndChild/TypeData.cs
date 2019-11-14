using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An
{
    class TypeData : SQLiteManage
    {
        public override void Close()
        {
            base.Close();
        }

        public override void Insert(object values)
        {
            base.Insert(values);
        }

        public override void Insert(string TableName, List<string> columns, List<string> values)
        {
            base.Insert(TableName, columns, values);
        }

        public override DataTable ReadDataTable()
        {
            cnn.Open();
            cmd.CommandText = "select * from Type";
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
