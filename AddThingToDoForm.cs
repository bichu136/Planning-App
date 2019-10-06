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
    public partial class AddThingToDoForm : Form
    {
        public AddThingToDoForm()
        {
            InitializeComponent();
            TypeCbBox.DisplayMemberChanged += TypeChange;
        }

        private void TypeChange(object sender, EventArgs e)
        {
            switch (TypeCbBox.SelectedIndex)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
