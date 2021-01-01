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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmdethi = new frmDeThi();
            Application.Run(new frmThemDeThi());
        }
    }
}
