using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_XDUDTN
{
    public partial class ỨngDụngTrắcNghiệm : Form
    {
        public ỨngDụngTrắcNghiệm()
        {
            InitializeComponent();
        }

        private void ỨngDụngTrắcNghiệm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/Users/admin/Desktop/background-powerpoint-dep-cho-bai-thuyet-trinh-chuyen-nghiep-01.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BTN_DangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ThongTin f = new Form_ThongTin();
            f.ShowDialog();
            this.Close();
        }
    }
}
