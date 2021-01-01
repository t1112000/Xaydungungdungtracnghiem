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

namespace DoAn_XDUDTN.folderPhongThi
{
    public partial class frmThemDeThi : Form
    {
        private List<CauHoi> lstCauhoi;
        private frmDe frmDe;

        public frmThemDeThi()
        {
            InitializeComponent();
        }

        private void frmThemDeThi_Load(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var phongthis = db.PhongThis.ToList();
                cbo_Phongthi.DataSource = phongthis;
                cbo_Phongthi.DisplayMember = "Ten";
                cbo_Phongthi.ValueMember = "IDpt";
            }    
        }

        private void cbo_Phongthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPhongThi();
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var phongthi = db.PhongThis.FirstOrDefault(x => x.IDpt.ToString() == cbo_Phongthi.SelectedValue.ToString());

                if (phongthi == null)
                    return;

                var dethi = db.DeThis.Where(x => x.Monhoc == phongthi.Monthi);
                gview_Khode.DataSource = dethi;
                gview_Khode.Columns["MonHoc1"].Visible = false;
            }
        }
        private void gview_Khode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var query = db.DethiVaCauhois.Where(x => x.Dethi.ToString() == gview_Khode.CurrentRow.Cells[0].Value.ToString()).ToList();
                var cauhois = query.Select(x => db.CauHois.FirstOrDefault(i => i.IDch == x.Cauhoi)).ToList();
                lstCauhoi = cauhois;
                LoadCauHoi();
            }
        }
        private void loadPhongThi()
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var phong = db.PhongthiVaDethis.Where(x => x.Phongthi.ToString() == cbo_Phongthi.SelectedValue.ToString());
                gview_Dethi.DataSource = phong;
                gview_Dethi.Columns["DeThi1"].Visible = false;
                gview_Dethi.Columns["PhongThi1"].Visible = false;
            }
        }
        public void LoadCauHoi()
        {
            if (frmDe == null)
                frmDe = new frmDe();

            frmDe.ResetForm();
            frmDe.TopLevel = false;
            frmDe.AutoScroll = true;
            frmDe.Location = new Point(10, gbox_Dethi.Location.Y);
            frmDe.Size = new Size(gbox_Dethi.Size.Width - 30, gbox_Dethi.Size.Height - 50);
            frmDe.LoadDe(lstCauhoi);
            this.gbox_Dethi.Controls.Add(frmDe);
            frmDe.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                if (db.PhongthiVaDethis.FirstOrDefault(x => x.Dethi.ToString() == gview_Khode.CurrentRow.Cells[0].Value.ToString()) != null)
                {
                    MessageBox.Show("Đề thi đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PhongthiVaDethi dethi = new PhongthiVaDethi();
                dethi.Phongthi = int.Parse(cbo_Phongthi.SelectedValue.ToString());
                dethi.Dethi = int.Parse(gview_Khode.CurrentRow.Cells[0].Value.ToString());

                db.PhongthiVaDethis.InsertOnSubmit(dethi);
                db.SubmitChanges();
            }

            loadPhongThi();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                PhongthiVaDethi dethi = db.PhongthiVaDethis.FirstOrDefault(x => x.Dethi.ToString() == gview_Khode.CurrentRow.Cells[0].Value.ToString());
                
                if (dethi == null)
                    return;
                
                db.PhongthiVaDethis.DeleteOnSubmit(dethi);
                db.SubmitChanges();
            }

            loadPhongThi();
        }
    }
}
