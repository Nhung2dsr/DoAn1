using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace DAL
{
    public class DonHangNhapDAL:DatabaseConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DataTable GetDonHangNhap()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * From DonHangNhap ORDER BY MaDHN DESC", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

        public DataTable GetDonHangNhapTK(string thang)
        {
            _con.Open();          
            da = new SqlDataAdapter("Select Sum(DonHangNhap.TongTien),Sum(DonHangBan.TongTien)from DonHangNhap inner join ChiTietDHN on ChiTietDHN.MaDHN = DonHangNhap.MaDHN inner join MatHang on MatHang.MaMH = ChiTietDHN.MaMH inner join ChiTietDHB on ChiTietDHB.MaMH = MatHang.MaMH inner join DonHangBan on DonHangBan.MaDHB = ChiTietDHB.MaDHB where Month(DonHangNhap.NgayNhap)='" + thang + "' and Month(DonHangBan.NgayBan)='" + thang + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable GetDonHangNhapTKe(string thang)
        {
            _con.Open();
            da = new SqlDataAdapter("Select MaDHN, NgayNhap,TongTien from DonHangNhap where Month(NgayNhap)='" + thang + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

        void ThucThiSQL(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public int KiemTraMaTrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from DonHangNhap where MaDHN='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool ThemHD(DonHangNhapDTO dn)
        {
          
            string sql = "Insert into DonHangNhap values(N'" + dn.MaNCC + "','" + dn.NgayNhap + "','" + dn.TongTien + "')";
            ThucThiSQL(sql);
            return true;
        }
        public bool SuaHD(DonHangNhapDTO dn)
        {
            string ngay = string.Format("{0}/{1}/{2}", dn.NgayNhap.Year, dn.NgayNhap.Month, dn.NgayNhap.Day);
            string sql = "Update DonHangNhap set MaNCC='" + dn.MaNCC + "', NgayNhap=N'" + ngay + "', TongTien='" + dn.TongTien + "' where MaDHN='" + dn.MaDHN + "'";
            ThucThiSQL(sql);
            return true;
        }
        public bool XoaHD(string ma)
        {
            string sql = "Delete from DonHangNhap where MaDHN='" + ma + "'";
            ThucThiSQL(sql);
            return true;
        }

    }
}
