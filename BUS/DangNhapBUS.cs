using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;


namespace BUS
{
    public class DangNhapBUS
    {
        DangNhapDAL daldn = new DangNhapDAL();
        public DataTable GetDangNhap()
        {
            return daldn.GetTaiKhoan();
        }
        public DataTable GetMK()
        {
            return daldn.GetMK();
        }
        public int KiemTraTaiKhoan(string ten, string mk)
        {
            return daldn.KiemTraTaiKhoan(ten, mk);
        }
        public int KiemTraEmaiMatKhau(string email, string mk)
        {
            return daldn.KiemTraEmailMatKhau(email, mk);
        }
        public int KiemTraEmai(string email)
        {
            return daldn.KiemTraEmail(email);
        }
        public bool suaMK(DangNhapDTO dn)
        {
            return daldn.SuaMK(dn);
        }


    }
}
