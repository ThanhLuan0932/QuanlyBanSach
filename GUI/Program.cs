using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
            Application.Run(new frmDangNhap());
            //Application.Run(new frmDoThiCot());
            //Application.Run(new frmInHoaDon());
            //Application.Run(new frmBanSach());
            //Application.Run(new frmNhapSach());
            
        }
    }
}
