using DoAn_XDUDTN._Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DoAn_XDUDTN
{
    public partial class frmDe : Form
    {
        public frmDe()
        {
            InitializeComponent();
        }

        private void frmDe_Load(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                LoadDe(db.CauHois.Take(5).ToList());
            }
        }

        public void LoadDe(List<CauHoi> lstCauHoi)
        {
            for(int i = 0; i < lstCauHoi.Count; i++)
            {
                Panel panel = new Panel();
                Label label = new Label();

                label.Text = "cau hoi " + (i + 1) + ": " + lstCauHoi[i].Noidung;
                label.AutoSize = true;
                panel.Controls.Add(label);

                var lstDapAnDung = lstDapAn(lstCauHoi[i].Dapandung);

                for (int j = 0; j < lstDapAnDung.Count; j++)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = lstDapAnDung[j];
                    radioButton.Location = new Point(30, label.Location.Y + (radioButton.Size.Height * j));
                    radioButton.AutoSize = true;
                    panel.Controls.Add(radioButton);
                }

                var lstDapAnSai = lstDapAn(lstCauHoi[i].Dapansai);

                for (int j = 0; j < lstDapAnSai.Count; j++)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = lstDapAnSai[j];
                    radioButton.Location = new Point(30, label.Location.Y + (radioButton.Size.Height * j));
                    radioButton.Size = new Size(60, label.Location.Y + (radioButton.Size.Height * j));
                    panel.Controls.Add(radioButton);
                }

                panel.Location = new Point(10, 80 * i);
                panel.Size = new Size(this.Size.Width, 80);
                this.Controls.Add(panel);
            }
        }

        public List<string> lstDapAn(string value)
        {
            string[] query = value.Split('~');
            return query.ToList();
        }
    }
}
