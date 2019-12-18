using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Do_An
{
    public partial class SettingsComponent : DevExpress.XtraEditors.XtraUserControl
    {
        public SettingsComponent()
        {
            InitializeComponent();
            comboBox1.Items.Add("Vung Tau");
            comboBox1.Items.Add("Bac Giang");
            comboBox1.Items.Add("Bac Kan");
            comboBox1.Items.Add("thanh pho Bac Lieu");
            comboBox1.Items.Add("Bac Ninh");
            comboBox1.Items.Add("Bien Hoa");
            comboBox1.Items.Add("Cu Chi");
            comboBox1.Items.Add("Cao Lanh");
            comboBox1.Items.Add("Cam Ranh");
            comboBox1.Items.Add("Thu Dau Mot");
            comboBox1.Items.Add("Dong Xoai");
            comboBox1.Items.Add("My Tho");
            comboBox1.Items.Add("Ca Mau");
            comboBox1.Items.Add("Cao Bang");
            comboBox1.Items.Add("Dong Ha");
            comboBox1.Items.Add("Ha Giang");
            comboBox1.Items.Add("Ha Tinh");
            comboBox1.Items.Add("Hai Duong");
            comboBox1.Items.Add("Hoa Binh");
            comboBox1.Items.Add("Hung Yen");
            comboBox1.Items.Add("Ha Long");
            comboBox1.Items.Add("La Gi");
            comboBox1.Items.Add("Lai Chau");
            comboBox1.Items.Add("Lang Son");
            comboBox1.Items.Add("Tan An");
            comboBox1.Items.Add("Nam Dinh");
            comboBox1.Items.Add("Nghe An");
            comboBox1.Items.Add("Ninh Binh");
            comboBox1.Items.Add("Quang Ngai");
            comboBox1.Items.Add("Qui Nhon");
            comboBox1.Items.Add("Pleiku");
            comboBox1.Items.Add("Quang Tri");
            comboBox1.Items.Add("Soc Trang");
            comboBox1.Items.Add("Son La");
            comboBox1.Items.Add("Tay Ninh");
            comboBox1.Items.Add("Thai Binh");
            comboBox1.Items.Add("Thai Nguyen");
            comboBox1.Items.Add("Thanh Hoa");
            comboBox1.Items.Add("Hue");
            comboBox1.Items.Add("Tra Vinh");
            comboBox1.Items.Add("Tuyen Quang");
            comboBox1.Items.Add("Vinh Long");
            comboBox1.Items.Add("Vinh");
            comboBox1.Items.Add("Tuy Hoa");
            comboBox1.Items.Add("Yen Bai");
            comboBox1.Items.Add("Can Tho");
            comboBox1.Items.Add("Ha Noi");
            comboBox1.Items.Add("thanh pho Ho Chi Minh");
            comboBox1.SelectedIndex = 0;
            comboBox1.TextChanged += ComboBox1_TextChanged;
        }
        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("ThoiTiet.txt", comboBox1.Text);
            Program.ThoiTiet = comboBox1.Text;
        }
    }
}
