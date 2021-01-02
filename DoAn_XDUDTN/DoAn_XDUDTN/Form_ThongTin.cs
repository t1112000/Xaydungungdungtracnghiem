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
    public partial class Form_ThongTin : Form
    {
        public Form_ThongTin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("C:/Users/admin/Desktop/background-powerpoint-dep-cho-bai-thuyet-trinh-chuyen-nghiep-01.png");
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Label_NgayThi.Text = DateTime.Now.ToShortDateString();

            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var sv = db.SinhViens.FirstOrDefault(x => x.IDsv.ToString() == User.id);

                Label_Name.Text = sv.Ten;
            }    
        }

        public DateTime FormatDate(DateTime date)
        {
            var ngay = date.Month + "/" +
                        date.Day + "/" +
                        date.Year;

            return DateTime.Parse(ngay);
        }

        private void cbo_Mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var phong = db.PhongThis.Where(x => x.Thoigianthi > FormatDate(DateTime.Now) && x.Thoigianthi < (FormatDate(DateTime.Now) + TimeSpan.FromDays(1)));
                var ds = phong.Where(x => x.Monthi.ToString() == cbo_Mon.SelectedValue.ToString());

                cbo_Phongthi.DataSource = ds;
                cbo_Phongthi.DisplayMember = "Phong";
                cbo_Phongthi.ValueMember = "IDpt";

            }
        }

        private void cbo_Phongthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var phong = db.PhongThis.FirstOrDefault(x => x.IDpt.ToString() == cbo_Phongthi.SelectedValue.ToString());
                lab_thoigian.Text = phong.Thoigianlam + "phút";
            }
        }

        private void cbo_Mon_DropDown(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var phong = db.PhongThis.Where(x => x.Thoigianthi > FormatDate(DateTime.Now) && x.Thoigianthi < (FormatDate(DateTime.Now) + TimeSpan.FromDays(1)));

                if (phong == null)
                    return;

                List<MonHoc> mons = new List<MonHoc>();
                foreach(PhongThi i in phong)
                {
                    mons.Add(db.MonHocs.FirstOrDefault(x => x.IDmh == i.Monthi));
                }

                cbo_Mon.DataSource = mons;
                cbo_Mon.DisplayMember = "Ten";
                cbo_Mon.ValueMember = "IDmh";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var phong = db.DanhSachPhongThis.FirstOrDefault(x => x.Phongthi.ToString() == cbo_Phongthi.SelectedValue.ToString()
                && x.Thisinh == User.username);

                if (phong == null)
                {
                    MessageBox.Show("Sinh viên không có trong phòng thi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.Hide();
                Form_CauHoiThi f = new Form_CauHoiThi();
                f.ShowDialog();
                this.Close();
            }    
        }
    }
}
