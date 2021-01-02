using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_XDUDTN.folderPhongThi;
using DoAn_XDUDTN.Properties;

namespace DoAn_XDUDTN
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void item_taocauhoi_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();

            if (Program.frmcauhoi == null)
                Program.frmcauhoi = new frmCauHoi();

            Program.frmcauhoi.TopLevel = false;
            panel.Controls.Add(Program.frmcauhoi);
            Program.frmcauhoi.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void item_taodethi_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();

            if (Program.frmdethi == null)
                Program.frmdethi = new frmDeThi();

            Program.frmdethi.TopLevel = false;
            panel.Controls.Add(Program.frmdethi);
            Program.frmdethi.Show();
        }

        private void item_taophongthi_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();

            if (Program.frmphongthi == null)
                Program.frmphongthi = new frmPhongThi();

            Program.frmphongthi.TopLevel = false;
            panel.Controls.Add(Program.frmphongthi);
            Program.frmphongthi.Show();
        }

        private void item_themde_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();

            if (Program.frmthemdethi == null)
                Program.frmthemdethi = new frmThemDeThi();

            Program.frmthemdethi.TopLevel = false;
            panel.Controls.Add(Program.frmthemdethi);
            Program.frmthemdethi.Show();
        }

        private void item_Dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
            this.Close();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}
