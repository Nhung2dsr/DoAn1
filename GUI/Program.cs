using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmDangNhap dangNhap = new FrmDangNhap();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMain()); // Đăng nhập thành công -> mở Main
            }
            else
            {
                Application.Exit(); // Đăng nhập thất bại hoặc thoát -> đóng app
            }
        }
    }
}
