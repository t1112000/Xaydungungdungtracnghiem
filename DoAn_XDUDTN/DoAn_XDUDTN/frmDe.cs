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
        public int locationY = 0;
        public frmDe()
        {
            InitializeComponent();
        }

        private void frmDe_Load(object sender, EventArgs e)
        {
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
                    radioButton.AutoSize = true;
                    radioButton.Location = new Point(30, label.Location.Y + label.Size.Height + (radioButton.Size.Height * j));
                    panel.Controls.Add(radioButton);
                }

                var lstDapAnSai = lstDapAn(lstCauHoi[i].Dapansai);

                for (int j = 0; j < lstDapAnSai.Count; j++)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = lstDapAnSai[j];
                    radioButton.AutoSize = true;
                    radioButton.Location = new Point(30, radioButton.Size.Height + label.Location.Y + label.Size.Height + (radioButton.Size.Height * j));
                    panel.Controls.Add(radioButton);
                }

                panel.Location = new Point(10, locationY);
                panel.AutoSize = true;
                locationY += panel.Size.Height + 10;
                this.Controls.Add(panel);
            }
        }

        public void ResetForm()
        {
            this.Controls.Clear();
            locationY = 0;
        }

        public List<string> lstDapAn(string value)
        {
            string[] query = value.Split('~');
            return query.ToList();
        }
    }
}
