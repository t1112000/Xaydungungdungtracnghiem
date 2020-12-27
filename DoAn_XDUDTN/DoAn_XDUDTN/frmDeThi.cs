using DoAn_XDUDTN._Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DoAn_XDUDTN
{
    public partial class frmDeThi : Form
    {
        private List<CauHoi> lstCauhoi;
        private List<int> lstIndexCauHoi;
        private frmDe frmDe;
        public frmDeThi()
        {
            InitializeComponent();
        }

        private void txt_SoCauHoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void frmDeThi_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
            LoadDeThi(cbo_MonHoc.SelectedValue.ToString());
        }
        
        private void cbmBox_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                LoadDeThi(cbo_MonHoc.SelectedValue.ToString());
            }
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            var check = KTSoCauHoi(int.Parse(txt_SoCauHoi.Text));

            if (check)
            {
                if (lstCauhoi != null && lstCauhoi.Count > 0)
                    lstCauhoi.Clear();

                if (lstIndexCauHoi != null && lstIndexCauHoi.Count > 0)
                    lstIndexCauHoi.Clear();

                for(int i = 0; i < int.Parse(txt_SoCauHoi.Text); i++)
                {
                    Random_CauHoi(ref lstCauhoi, ref lstIndexCauHoi);
                }

                LoadCauHoi();
            }
            else
            {
                MessageBox.Show("Số câu hỏi không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Doi_Click(object sender, EventArgs e)
        {
            frmListCauHoi lstCH = new frmListCauHoi();
            lstCH.load(lstIndexCauHoi, int.Parse(cbo_MonHoc.SelectedValue.ToString()));
            lstCH.ShowDialog();
        }

        public void LoadCauHoi()
        {
            if (frmDe == null)
                frmDe = new frmDe();

            frmDe.ResetForm();
            frmDe.TopLevel = false;
            frmDe.AutoScroll = true;
            frmDe.Location = new Point(10, gBox_DeThi.Location.Y);
            frmDe.Size = new Size(gBox_DeThi.Size.Width - 30, gBox_DeThi.Size.Height - 50);
            frmDe.LoadDe(lstCauhoi);
            this.gBox_DeThi.Controls.Add(frmDe);
            frmDe.Show();
        }

        private void Random_CauHoi(ref List<CauHoi> lstCH, ref List<int> lstIndex)
        {
            Random rd = new Random();
            
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                int index = rd.Next(1, db.CauHois.Count());
                while(lstIndex != null && lstIndex.IndexOf(index) != -1)
                {
                    index = rd.Next(1, db.CauHois.Count());
                }

                if (lstCH == null)
                    lstCH = new List<CauHoi>();
                
                lstCH.Add(db.CauHois.Where(x => x.Monhoc.ToString().Equals(cbo_MonHoc.SelectedValue.ToString())).Skip(index - 1).Take(1).First());

                if (lstIndex == null)
                    lstIndex = new List<int>();

                lstIndex.Add(index);
            }
        }
        private void LoadMonHoc()
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                cbo_MonHoc.DataSource = db.MonHocs.ToList();
                cbo_MonHoc.DisplayMember = "Ten";
                cbo_MonHoc.ValueMember = "IDmh";
            }
        }

        private void LoadDeThi(string id)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                if (string.IsNullOrEmpty(id))
                    gview_DsDe.DataSource = db.DeThis.ToList();
                else
                    gview_DsDe.DataSource = db.DeThis.Where(x => x.Monhoc.ToString() == id);

                gview_DsDe.Columns["MonHoc1"].Visible = false;
            }
        }

        private bool KTSoCauHoi(int number)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                if (number > db.CauHois.Count())
                    return false;
            }

            double value = number;
            string heso = ((double)10 / value).ToString("0,0.##########");

            try
            {
                double.Parse(heso.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
                return false;
            }

            var ketqua = double.Parse(heso) * value;

            if (ketqua == 10.0)
            {
                return true;
            }

            return false;
        }

        public void DoiCauHoi(List<int> lstcauhoidoi)
        {
            Random rd = new Random();
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                foreach (int i in lstcauhoidoi)
                {
                    int index = rd.Next(1, db.CauHois.Count());

                    while(lstcauhoidoi.IndexOf(index) != -1)
                    {
                        index = rd.Next(1, db.CauHois.Count());
                    }

                    lstCauhoi[i] = db.CauHois.Where(x => x.Monhoc.ToString().Equals(cbo_MonHoc.SelectedValue.ToString())).Skip(index - 1).Take(1).First();
                    lstIndexCauHoi[i] = index;
                }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {

            }
        }
    }
}
