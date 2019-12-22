using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Do_An
{
    public partial class AddStatsForm : DevExpress.XtraEditors.XtraForm
    {
        public AddThingsToDoComponent parent;
        public AddStatsForm()
        {
            InitializeComponent();
        }
        public AddStatsForm(AddThingsToDoComponent Parent)
        {
            parent = Parent;
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            List<string> buffer = new List<string>() { NameTxtBox.Text, DesTxtBox.Text };
            parent.data.Insert(buffer);
            //Program.manager.Insert("Stats", new List<string> { "Name", "Description" }, new List<string> { Buffer1, Buffer2 });
            parent.statsCbBox.DataSource = parent.data.ReadDataTable();
            this.Close();
        }
    }
}