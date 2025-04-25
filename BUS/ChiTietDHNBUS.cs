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
    public class ChiTietDHNBUS
    {
        ChiTietDHNDAL ctnDAL = new ChiTietDHNDAL();
        public DataTable GetChiTietNhap()
        {
            return ctnDAL.GetChiTietDHN();
        }
        public int KiemTraMaTrung (string ma)
        {
            return ctnDAL.KiemTraMaTrung(ma);
        }
        public bool ThemCTN(ChiTietDHNDTO ctn)
        {
            return ctnDAL.ThemCTN(ctn);
        }
        public bool SuaCTN (ChiTietDHNDTO ctn)
        {
            return ctnDAL.SuaCTN(ctn);
        }
        public bool XoaCTN (string ma)
        {
            return ctnDAL.XoaCTN(ma);
        }
        public bool XoaHD (string ma)
        {
            return ctnDAL.XoaHD(ma);
        }
        public DataTable GetSpByMaN(string man)
        {
            return ctnDAL.GetSpByMaN(man);
        }
        public DataTable TachMa (string ma)
        {
            return ctnDAL.TachMa(ma);
        }

    }
}
