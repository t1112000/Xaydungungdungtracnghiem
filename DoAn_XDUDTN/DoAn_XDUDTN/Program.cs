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
            frmdethi = new frmDeThi();
            Application.EnableVisualStyles();
            Application.Run(frmdethi);
            Application.SetCompatibleTextRenderingDefault(false);
        }
    }
}
