using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Security.RightsManagement;


namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAL spDAL = new SanPhamDAL();
        public DataTable GetSanPham()
        {
            return spDAL.GetSanPham();
        }
        public DataTable GetSanPhamSL(string ma)
        {
            return spDAL.GetSanPhamSL(ma);
        }
        public int KiemTraMaTrung(string ma)
        {
            return spDAL.KiemTraMaTrung(ma);
        }
        public bool ThemSP (SanPhamDTO SanPham)
        {
            return spDAL.ThemSP(SanPham);
        }
        public bool SuaSP (SanPhamDTO SanPham)
        {
            return spDAL.SuaSP(SanPham);
        }
        public bool XoaSP (string ma)
        {
            return spDAL.XoaSP(ma);
        }
    }
}
