using DoAn_XDUDTN._Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAn_XDUDTN
{
    public partial class frmCauHoi : Form
    {
        private List<CauTL> CauTLD;
        private List<CauTL> CauTLS; 
        public frmCauHoi()
        {
            InitializeComponent();
        }

        private void frmCauHoi_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetCauHoi(cboMonHoc.SelectedValue.ToString());
                txt_ID.Clear();
                txt_CauHoi.Clear();
                txt_TLDung.Clear();
                txt_TLSai.Clear();
                CauTLD = null;
                CauTLS = null;
            }
            catch(Exception ex)
            {

            }
        }

        private void gviewDSCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = gviewDSCauHoi.CurrentRow.Cells[0].Value.ToString();
            txt_CauHoi.Text = gviewDSCauHoi.CurrentRow.Cells[2].Value.ToString();

            if (CauTLD == null)
                CauTLD = new List<CauTL>();

            CauTLD = GetCauTL(gviewDSCauHoi.CurrentRow.Cells[3].Value.ToString());

            if (CauTLD.Count > 1)
                radio_Multi.Checked = true;
            else
                radio_SimpleChoose.Checked = true;

            gviewCauTraLoiDung.DataSource = CauTLD;

            if (CauTLS == null)
                CauTLS = new List<CauTL>();

            CauTLS = GetCauTL(gviewDSCauHoi.CurrentRow.Cells[4].Value.ToString());

            gviewCauTraLoiSai.DataSource = CauTLS;
        }

        private void gviewCauTraLoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TLDung.Text = gviewCauTraLoiDung.CurrentRow.Cells[1].Value.ToString();
        }

        private void gviewCauTraLoiSai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TLSai.Text = gviewCauTraLoiSai.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_addCauHoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CauHoi.Text) || CauTLD == null || CauTLS == null || cboMonHoc.SelectedValue == null)
            {
                MessageBox.Show("value do not empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                CauHoi cauhoi = new CauHoi
                {
                    Monhoc = int.Parse(cboMonHoc.SelectedValue.ToString()),
                    Noidung = txt_CauHoi.Text,
                    Dapandung = CreateCauLT(CauTLD),
                    Dapansai = CreateCauLT(CauTLS)
                };

                db.CauHois.InsertOnSubmit(cauhoi);
                db.SubmitChanges();
            }

            GetCauHoi(cboMonHoc.SelectedValue.ToString());
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            using(dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                txt_ID.Text = db.CauHois.OrderByDescending(x => x.IDch).First().IDch + 1 + "";
                txt_CauHoi.Clear();
                txt_TLDung.Clear();
                txt_TLSai.Clear();
                CauTLD = new List<CauTL>();
                CauTLS = new List<CauTL>();
                gviewCauTraLoiDung.DataSource = CauTLD;
                gviewCauTraLoiSai.DataSource = CauTLS;
                radio_SimpleChoose.Checked = true;
            }
        }

        private void btn_AddCauTraLoiD_Click(object sender, EventArgs e)
        {
            this.CauTLD.Add(new CauTL { STT = CauTLD.Count + 1, Value = txt_TLDung.Text });

            gviewCauTraLoiDung.DataSource = null;
            gviewCauTraLoiDung.DataSource = CauTLD;
        }

        private void btn_DeleteCauHoi_Click(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                CauHoi ch = db.CauHois.FirstOrDefault(x => x.IDch.ToString() == gviewDSCauHoi.CurrentRow.Cells[0].Value.ToString());

                db.CauHois.DeleteOnSubmit(ch);
                db.SubmitChanges();
            }

            GetCauHoi(cboMonHoc.SelectedValue.ToString());
        }

        private void btn_AddCauTraLoi_Click(object sender, EventArgs e)
        {
            this.CauTLS.Add(new CauTL { STT = CauTLS.Count + 1, Value = txt_TLSai.Text });
            gviewCauTraLoiSai.DataSource = null;
            gviewCauTraLoiSai.DataSource = CauTLS;
        }

        private void btn_DeleteCauTraLoiD_Click(object sender, EventArgs e)
        {
            int stt = gviewCauTraLoiDung.CurrentRow.Index;

            CauTLD.Remove(CauTLD[stt]);
            CauTLD = CauTLD.Select((x, y) => new CauTL { STT = y + 1, Value = x.Value }).ToList();
            gviewCauTraLoiDung.DataSource = null;
            gviewCauTraLoiDung.DataSource = CauTLD;
        }

        private void btn_DeleteCauTraLoii_Click(object sender, EventArgs e)
        {
            int stt = gviewCauTraLoiSai.CurrentRow.Index;

            CauTLS.RemoveAt(stt);
            CauTLS = CauTLS.Select((x, y) => new CauTL { STT = y + 1, Value = x.Value }).ToList();
            gviewCauTraLoiSai.DataSource = null;
            gviewCauTraLoiSai.DataSource = CauTLD;
        }

        private void btn_CauHoiEdit_Click(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                CauHoi ch = db.CauHois.FirstOrDefault(x => x.IDch.ToString() == gviewDSCauHoi.CurrentRow.Cells[0].Value.ToString());

                ch.Noidung = txt_CauHoi.Text;
                ch.Dapandung = CreateCauLT(CauTLD);
                ch.Dapansai = CreateCauLT(CauTLS);
                db.SubmitChanges();

                GetCauHoi(cboMonHoc.SelectedValue.ToString());
            }
        }

        private void btn_CauTLDEdit_Click(object sender, EventArgs e)
        {
            int index = gviewCauTraLoiDung.CurrentRow.Index;

            CauTLD[index].Value = txt_TLDung.Text;
            gviewCauTraLoiDung.DataSource = null;
            gviewCauTraLoiDung.DataSource = CauTLD;
        }

        private void btn_CauTLSEdit_Click(object sender, EventArgs e)
        {
            int index = gviewCauTraLoiSai.CurrentRow.Index;

            CauTLS[index].Value = txt_TLSai.Text;
            gviewCauTraLoiSai.DataSource = null;
            gviewCauTraLoiSai.DataSource = CauTLS;
        }

        private void loadData()
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                cboMonHoc.DataSource = db.MonHocs.ToList();
                cboMonHoc.DisplayMember = "Ten";
                cboMonHoc.ValueMember = "IDmh";
            }    
        }

        private void GetCauHoi(string idMH)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                if (!string.IsNullOrEmpty(idMH))
                    gviewDSCauHoi.DataSource = db.CauHois.Where(x => x.Monhoc == int.Parse(idMH)).ToList();

                gviewDSCauHoi.Columns["Monhoc1"].Visible = false;
            }
        }

        private List<CauTL> GetCauTL(string value)
        {
            string[] query = value.Split('~');

            List<CauTL> lstCauTL = query.Select((x, y) => new CauTL { STT = y + 1, Value = x }).ToList();

            return lstCauTL;
        }

        private string CreateCauLT(List<CauTL> lstCauTL)
        {
            List<string> cautls = new List<string>();

            for (int i = 0; i < lstCauTL.Count; i++)
            {
                cautls.Add(lstCauTL[i].Value);
            }

            if (cautls.Count == 1)
                return cautls[0];

            string query = "";

            foreach(string i in cautls)
            {
                query += i + "~";
            }

            query = query.Substring(0, query.Length - 1);

            return query;
        }
    }
}
