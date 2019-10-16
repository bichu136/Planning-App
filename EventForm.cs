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
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();

        }
        private AddEventForm addEventForm;

        private void Add_Button_Click(object sender, EventArgs e)
        {
            addEventForm = new AddEventForm();
            addEventForm.ShowDialog();
        }
    }
}
