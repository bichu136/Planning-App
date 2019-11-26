using System.Collections.Generic;
using System.Data;

namespace Do_An
{
    class StatData : SQLiteManage
    {
        public StatData()
        {
        }

        public override void Close()
        {
            base.Close();
        }

        public override void Insert(object values)
        {
            List<string> input = (List<string>)values;
            cnn.Open();
            cmd.CommandText = "insert into Stats (Name,Description)values ($Name,$Des)";
            cmd.Parameters.AddWithValue("$Name",input[0]);
            cmd.Parameters.AddWithValue("$Des", input[1]);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public override void Insert(string TableName, List<string> columns, List<string> values)
        {
            
            base.Insert(TableName, columns, values);
        }

        public DataTable ReadDataTable()
        {
            cnn.Open();
            cmd.CommandText = "select ID,Name from Stats";
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