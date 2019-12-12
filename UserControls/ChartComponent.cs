using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An.UserControls
{
    public partial class ChartComponent : UserControl
    {
        RecordData rData = new RecordData();
        public ChartComponent()
        {
            
            InitializeComponent();
            DataTable x = rData.GetAllScores();
            
            chart1.DataSource = x;
            //chart1.Series.Clear();
            chart1.Series["Series1"].YValueMembers = "x";
            chart1.Series["Series1"].IsXValueIndexed = true;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart1.Series["Series1"].XValueMember = "Name";
            chart1.Legends.Clear();
            //foreach (DataRow row in x.Rows)
            //{
            //    //chart1.Series.Add(row.Field<String>("Name"));
            //    chart1.Series[row.Field<String>("Name")].YValueMembers = "x";
            // }


        }
    }
}
