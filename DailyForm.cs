using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An
{
    
    public partial class DailyForm : Form
    {
        DataTable dt;
        DailyData Dailydata;
        public DailyForm()
        {
            //Program.manager.DataAdapter.SelectCommand.CommandText = "select";
            //Program.manager.DataAdapter.Fill(dt);
            InitializeComponent();
            
        }
        public void getDailyTask()
        {

        }
        private void Update_button_Click(object sender, EventArgs e)
        {

        }
        
        private void Cancel_Button_Click(object sender, EventArgs e)
        {

        }

        private void DailyForm_Load(object sender, EventArgs e)
        {
            
            //DailyDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
        }
    }
}
