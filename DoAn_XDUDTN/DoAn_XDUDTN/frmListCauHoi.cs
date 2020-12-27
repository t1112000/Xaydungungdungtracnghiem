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
    public partial class frmListCauHoi : Form
    {
        private int locationY = 0;
        public List<int> position;
        int slCH = 0;
        int id;

        public frmListCauHoi()
        {
            InitializeComponent();
        }

        private void frmListCauHoi_Load(object sender, EventArgs e)
        {
            panelCH.AutoScroll = true;
        }

        public void load(List<int> lstCH, int idMon)
        {
            locationY += gbox_lstCH.Location.Y + 10;
            for(int i = 0; i < lstCH.Count; i++)
            {
                CheckBox cbox = new CheckBox();
                cbox.Text = "Câu " + (i + 1);
                cbox.Tag = i;
                cbox.Click += checkCH;
                cbox.Location = new Point(10, locationY);
                cbox.AutoSize = true;
                locationY += cbox.Size.Height + 10;
                panelCH.Controls.Add(cbox);
            }

            slCH = lstCH.Count();
            id = idMon;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            using (dbquanlythitracnghiemDataContext db = new dbquanlythitracnghiemDataContext())
            {
                if (position.Count() + slCH > db.CauHois.Where(x => x.Monhoc == id).Count())
                {
                    MessageBox.Show("Không đủ câu hơi để đổi", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(Program.frmdethi != null)
                {
                    Program.frmdethi.DoiCauHoi(position);
                    Program.frmdethi.LoadCauHoi();
                    this.Close();
                }    
            }    
        }

        private void checkCH(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked == true)
            {
                checkBox.Checked = true;

                if (position == null)
                    position = new List<int>();

                position.Add((int)checkBox.Tag);
            }
            else
            {
                checkBox.Checked = false;
                position.Remove((int)checkBox.Tag);
            }
        }
    }
}
