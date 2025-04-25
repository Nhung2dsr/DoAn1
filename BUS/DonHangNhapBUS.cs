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
    public class DonHangNhapBUS
    {
        DonHangNhapDAL dnDAL = new DonHangNhapDAL();
        ChiTietDHNDAL ctnDAL = new ChiTietDHNDAL();
        public DataTable GetDonHangNhap()
        {
            return dnDAL.GetDonHangNhap();
        }
        public DataTable GetDonHangNhapTK(string thang)
        {
            return dnDAL.GetDonHangNhapTK(thang);
        }
        public DataTable GetDonHangNhapTKe(string thang)
        {
            return dnDAL.GetDonHangNhapTKe(thang);
        }
        public int KiemTraMaTrung(string ma)
        {
            return dnDAL.KiemTraMaTrung(ma);
        }
        public bool ThemHD(DonHangNhapDTO dn)
        {
            return dnDAL.ThemHD(dn);
        }
        public bool SuaHD(DonHangNhapDTO dn)
        {
            return dnDAL.SuaHD(dn);
        }
        public bool XoaHD(string ma)
        {
            return dnDAL.XoaHD(ma);
        }
        public DataTable GetChiTietNhap()
        {
            return ctnDAL.GetChiTietDHN();
        }
        public bool ThemCTN (ChiTietDHNDTO ctn)
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
    }
}
