using DoAn_XDUDTN._Data;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("C:/Users/admin/Desktop/background-powerpoint-dep-cho-bai-thuyet-trinh-chuyen-nghiep-01.png");
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BTN_DangNhap_Click(object sender, EventArgs e)
        {
            if (Radio_SV.Checked == true)
            {
                using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
                {
                    var sv = db.TaiKhoans.FirstOrDefault(x => x.Username == Text_MSSV.Text &&
                             x.Password == Text_MK.Text);

                    if (sv == null)
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "warnning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }

                    if (db.SinhViens.FirstOrDefault(x => x.IDdn == Text_MSSV.Text) == null)
                    {
                        MessageBox.Show("Sinh viên không tồn tại", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    User.create(db.SinhViens.FirstOrDefault(x => x.IDdn == sv.Username).IDsv.ToString(), Text_MSSV.Text);

                    this.Hide();
                    Form_ThongTin f = new Form_ThongTin();
                    f.ShowDialog();
                    this.Close();
                }    
            }

            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var sv = db.TaiKhoans.FirstOrDefault(x => x.Username == Text_MSSV.Text &&
                         x.Password == Text_MK.Text);

                if (sv == null)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (db.GiaoViens.FirstOrDefault(x => x.IDdn == Text_MSSV.Text) == null)
                {
                    MessageBox.Show("Giáo viên không tồn tại", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Hide();
                frmMenu menu = new frmMenu();
                menu.ShowDialog();
                this.Close();
            }
        }
    }
}
