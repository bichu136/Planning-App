using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;

namespace Do_An.UserControls
{
    public partial class SkinComponent : DevExpress.XtraEditors.XtraUserControl
    {
        public SkinComponent()
        {
            InitializeComponent();
            ColorPicker.EditValue = Default.color;
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(comboBoxEdit1.Text);
        }

        private void SkinComponent_Load(object sender, EventArgs e)
        {
            foreach (SkinContainer container in SkinManager.Default.Skins)
            {
                comboBoxEdit1.Properties.Items.Add(container.SkinName);

            }
        }

        private void ColorPicker_EditValueChanged(object sender, EventArgs e)
        {
            Default.color = (Color)ColorPicker.EditValue;
            this.Appearance.BackColor = Default.color;
        }
    }
}
