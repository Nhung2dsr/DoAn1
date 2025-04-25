using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAL khDAL = new KhachHangDAL();
        public DataTable GetKhachHang()
        {
            return khDAL.GetKhachHang();
        }
        public int KiemTraMaTrung(string ma)
        {
            return khDAL.KiemTraMaTrung(ma);
        }
        public bool ThemKH(KhachHangDTO KhachHang)
        {
            return khDAL.ThemKH(KhachHang);
        }
        public bool SuaKH(KhachHangDTO KhachHang)
        {
            return khDAL.SuaKH(KhachHang);
        }
        public bool XoaKH(string ma)
        {
            return khDAL.XoaKH(ma);
        }
    }
}
