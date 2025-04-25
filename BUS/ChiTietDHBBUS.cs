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
    public class ChiTietDHBBUS
    {
        ChiTietDHBDAL ctbDAL = new ChiTietDHBDAL();
        public DataTable GetChiTietBan()
        {
            return ctbDAL.GetChiTietDHB();
        }
        public int KiemTraMaTrung(string ma)
        {
            return ctbDAL.KiemTraMaTrung(ma);
        }
        public bool ThemCTB(ChiTietDHBDTO ctb)
        {
            return ctbDAL.ThemCTB(ctb);
        }
        public bool SuaCTB(ChiTietDHBDTO ctb)
        {
            return ctbDAL.SuaCTB(ctb);
        }
        public bool XoaCTB(string ma)
        {
            return ctbDAL.XoaCTB(ma);
        }
        public bool XoaHD(string ma)
        {
            return ctbDAL.XoaHD(ma);
        }
        public DataTable GetSpByMaB(string man)
        {
            return ctbDAL.GetSpByMaB(man);
        }
        public DataTable TachMa(string ma)
        {
            return ctbDAL.TachMa(ma);
        }
    }
}
