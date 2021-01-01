using DoAn_XDUDTN._Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAn_XDUDTN.folderPhongThi
{
    public partial class frmPhongThi : Form
    {
        private List<int> dtimeH;
        private List<int> dtimeMinute;
        private int[] dtimeLambai = { 30, 60, 90, 120};
        public frmPhongThi()
        {
            InitializeComponent();
        }

        private void frmPhongThi_Load(object sender, EventArgs e)
        {
            createData();
            loadData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                PhongThi phongthi = new PhongThi();
                phongthi.Monthi = int.Parse(cbo_Monhoc.SelectedValue.ToString());
                phongthi.Ten = txt_Kythi.Text;
                phongthi.Phong = txt_phongthi.Text;
                phongthi.Thoigianlam = int.Parse(cbo_Thoigianlam.SelectedValue.ToString());

                var tgthi = dtime_Ngaythi.Value.Month + "/" +
                            dtime_Ngaythi.Value.Day + "/" +
                            dtime_Ngaythi.Value.Year;

                var gio = double.Parse(cbo_Giobatdau.SelectedValue.ToString());
                var phut = (double.Parse(cbo_Phutbatdau.SelectedValue.ToString()) * 0.1) / 6.0;
                TimeSpan span = TimeSpan.FromHours(gio + phut);
                DateTime day = DateTime.Parse(tgthi) + span;

                phongthi.Thoigianthi = day;

                db.PhongThis.InsertOnSubmit(phongthi);
                db.SubmitChanges();
            }
            message();
        }
        private void cbo_CTKythi_DropDown(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                cbo_CTKythi.DataSource = db.PhongThis.ToList();
                cbo_CTKythi.DisplayMember = "Phong";
                cbo_CTKythi.ValueMember = "IDpt";
            }
        }
        private void cbo_CTKythi_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var phongthi = db.PhongThis.FirstOrDefault(x => x.IDpt.ToString() == cbo_CTKythi.SelectedValue.ToString());

                if (phongthi == null)
                    return;

                txt_phongthi.Text = phongthi.Phong;
                txt_Kythi.Text = phongthi.Ten;
                var danhsachPT = db.DanhSachPhongThis.Where(x => x.Phongthi == phongthi.IDpt).ToList();
                txt_CTSlhocsinh.Text = danhsachPT.Count().ToString();
                loadThiSinh(danhsachPT);
                cbo_Thoigianlam.Text = phongthi.Thoigianlam.ToString();
                cbo_Giobatdau.Text = phongthi.Thoigianthi.Value.Hour.ToString();
                cbo_Phutbatdau.Text = phongthi.Thoigianthi.Value.Minute.ToString();
                dtime_Ngaythi.Value = phongthi.Thoigianthi.Value.Date;
                cbo_Monhoc.Text = db.MonHocs.FirstOrDefault(x => x.IDmh == phongthi.Monthi).Ten;
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var phongthi = db.PhongThis.FirstOrDefault(x => x.IDpt.ToString() == cbo_CTKythi.SelectedValue.ToString());
                db.PhongThis.DeleteOnSubmit(phongthi);
                db.SubmitChanges();
            }
            message();
        }
        private void btn_auto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_auto.Text))
            {
                MessageBox.Show("không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var dshs = db.SinhViens.Where(x => x.Khoa == cbo_CTKhoa.SelectedValue.ToString()).OrderBy(x => x.Ten);

                if (int.Parse(txt_auto.Text) > dshs.Count())
                {
                    MessageBox.Show("Số lượng sinh viên quá nhiều", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var ds = dshs.Take(int.Parse(txt_auto.Text)).ToList();

                foreach(SinhVien i in ds)
                {
                    DanhSachPhongThi dspt = new DanhSachPhongThi();
                    dspt.Thisinh = i.IDdn;
                    dspt.Phongthi = int.Parse(cbo_CTKythi.SelectedValue.ToString());

                    db.DanhSachPhongThis.InsertOnSubmit(dspt);
                }

                db.SubmitChanges();

                var dsthisinh = db.DanhSachPhongThis.Where(x => x.Phongthi.ToString() == cbo_CTKythi.SelectedValue.ToString()).ToList();
                loadThiSinh(dsthisinh);
            }    
        }
        private void txt_auto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void cbo_CTKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var hs = db.SinhViens.Where(x => x.Khoa == cbo_CTKhoa.SelectedValue.ToString());

                gview_lsthocsinh.DataSource = hs;
                gview_lsthocsinh.Columns["Khoa1"].Visible = false;
                gview_lsthocsinh.Columns["Lop1"].Visible = false;
                gview_lsthocsinh.Columns["TaiKhoan"].Visible = false;
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                PhongThi phongthi = db.PhongThis.FirstOrDefault(x => x.IDpt.ToString() == cbo_CTKythi.SelectedValue.ToString());
                phongthi.Monthi = int.Parse(cbo_Monhoc.SelectedValue.ToString());
                phongthi.Ten = txt_Kythi.Text;
                phongthi.Phong = txt_phongthi.Text;
                phongthi.Thoigianlam = int.Parse(cbo_Thoigianlam.SelectedValue.ToString());

                var tgthi = dtime_Ngaythi.Value.Month + "/" +
                            dtime_Ngaythi.Value.Day + "/" +
                            dtime_Ngaythi.Value.Year;

                var gio = double.Parse(cbo_Giobatdau.SelectedValue.ToString());
                var phut = (double.Parse(cbo_Phutbatdau.SelectedValue.ToString()) * 0.1) / 6.0;
                TimeSpan span = TimeSpan.FromHours(gio + phut);
                DateTime day = DateTime.Parse(tgthi) + span;

                phongthi.Thoigianthi = day;

                db.PhongThis.InsertOnSubmit(phongthi);
                db.SubmitChanges();
            }
            message();
        }
        private void btn_addHS_Click(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                DanhSachPhongThi ds = new DanhSachPhongThi();
                string sinhvien = db.SinhViens.FirstOrDefault(x => x.IDsv.ToString() == gview_lsthocsinh.CurrentRow.Cells[0].Value.ToString()).IDdn;
                var ts = db.DanhSachPhongThis.FirstOrDefault(x => x.Thisinh == sinhvien);

                if (ts != null)
                {
                    MessageBox.Show("Sinh viên đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ds.Thisinh = sinhvien;
                ds.Phongthi = int.Parse(cbo_CTKythi.SelectedValue.ToString());

                db.DanhSachPhongThis.InsertOnSubmit(ds);
                db.SubmitChanges();

                var dspt = db.DanhSachPhongThis.Where(x => x.Phongthi.ToString() == cbo_CTKythi.SelectedValue.ToString()).ToList();
                loadThiSinh(dspt);
                txt_CTSlhocsinh.Text = db.DanhSachPhongThis.Where(x => x.Phongthi.ToString() == cbo_CTKythi.SelectedValue.ToString()).Count().ToString();
            }
        }
        private void btn_removeHS_Click(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                var sv = db.DanhSachPhongThis.FirstOrDefault(x => x.Phongthi.ToString() == gview_lst_thisinh.CurrentRow.Cells[0].Value.ToString());
                db.DanhSachPhongThis.DeleteOnSubmit(sv);
                db.SubmitChanges();

                var dspt = db.DanhSachPhongThis.Where(x => x.Phongthi.ToString() == gview_lst_thisinh.CurrentRow.Cells[0].Value.ToString()).ToList();
                loadThiSinh(dspt);
                txt_CTSlhocsinh.Text = db.DanhSachPhongThis.Where(x => x.Phongthi.ToString() == cbo_CTKythi.SelectedValue.ToString()).Count().ToString();
            }
        }
        private void loadData()
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                cbo_Monhoc.DataSource = db.MonHocs.ToList();
                cbo_Monhoc.DisplayMember = "Ten";
                cbo_Monhoc.ValueMember = "IDmh";

                dtime_Ngaythi.Value = DateTime.Now;

                cbo_Giobatdau.DataSource = dtimeH;
                cbo_Phutbatdau.DataSource = dtimeMinute;
                cbo_Thoigianlam.DataSource = dtimeLambai;

                cbo_CTKhoa.DataSource = db.Khoas.ToList();
                cbo_CTKhoa.DisplayMember = "TenKhoa";
                cbo_CTKhoa.ValueMember = "IDkhoa";
            }
        }

        private void createData()
        {
            dtimeH = new List<int>();
            dtimeMinute = new List<int>();

            for(int i = 0; i < 24; i++)
            {
                dtimeH.Add(i);
            }

            for (int i = 0; i < 60; i += 5)
            {
                dtimeMinute.Add(i);
            }
        }
        private void loadThiSinh(List<DanhSachPhongThi> lstThiSinh)
        {
            gview_lst_thisinh.DataSource = lstThiSinh;
            gview_lst_thisinh.Columns["TaiKhoan"].Visible = false;
            gview_lst_thisinh.Columns["PhongThi1"].Visible = false;
        }

        private void message()
        {
            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
