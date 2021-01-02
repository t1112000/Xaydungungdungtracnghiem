using DoAn_XDUDTN.folderPhongThi;
using System;
using System.Windows.Forms;

namespace DoAn_XDUDTN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static frmDeThi frmdethi;
        public static frmMenu frmmenu;
        public static frmCauHoi frmcauhoi;
        public static frmPhongThi frmphongthi;
        public static frmThemDeThi frmthemdethi;
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmdethi = new frmDeThi();
            frmmenu = new frmMenu();
            Application.Run(new frmDangNhap());
        }
    }
}
