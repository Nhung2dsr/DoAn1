using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class LoaiSanPhamBUS
    {
        LoaiSanPhamDAL dallh = new LoaiSanPhamDAL();
        public DataTable GetLoaiHang()
        {
            return dallh.GetLoaiSP();
        }
        public int KiemTraMaTrung(string ma)
        {
            return dallh.KiemTraMaTrung(ma);
        }
        public bool ThemLoaiSP(LoaiSanPhamDTO lh)
        {
            return dallh.ThemLoaiSP(lh);
        }
        public bool SuaLoaiSP(LoaiSanPhamDTO lh)
        {
            return dallh.SuaLoaiSP(lh);
        }
        public bool XoaLoaiSP(string ma)
        {
            return dallh.XoaLoaiSP(ma);
        }
    }
}
