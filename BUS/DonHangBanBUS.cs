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
    public class DonHangBanBUS
    {
        DonHangBanDAL dbDAL = new DonHangBanDAL();
        ChiTietDHBDAL ctbDAL = new ChiTietDHBDAL();
        public DataTable GetDonHangBan()
        {
            return dbDAL.GetDonHangBan();
        }
        public DataTable GetDonHangBanTKe()
        {
            return dbDAL.GetDonHangBanTKe();
        }
        public DataTable GetDonHangBanTKeThang(string thang)
        {
            return dbDAL.GetDonHangBanTKeThang(thang);
        }
        public int KiemTraMaTrung(string ma)
        {
            return dbDAL.KiemTraMaTrung(ma);
        }
        public bool ThemHD (DonHangBanDTO db)
        {
            return dbDAL.ThemHD(db);
        }
        public bool SuaHD (DonHangBanDTO db)
        {
            return dbDAL.SuaHD(db);
        }
        public bool XoaHD(string ma)
        {
            return dbDAL.XoaHD(ma);
        }
        public bool ThemCTB (ChiTietDHBDTO ctb)
        {
            return ctbDAL.ThemCTB(ctb);
        }
        public bool SuaCTB (ChiTietDHBDTO ctb)
        {
            return ctbDAL.SuaCTB(ctb);
        }
        public bool XoaCTB (string ma)
        {
            return ctbDAL.XoaCTB(ma);
        }
    }
}
