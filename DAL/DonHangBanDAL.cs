using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DonHangBanDAL:DatabaseConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable GetDonHangBan()
        {
            _con.Open();
            da = new SqlDataAdapter ("Select*From DonHangBan ORDER BY MaDHB DESC", _con);
            dt = new DataTable ();
            da.Fill (dt);
            _con.Close();
            return dt;
        }
        public DataTable GetDonHangBanTKe()
        {
            _con.Open();
            da = new SqlDataAdapter("Select MaDHB, NgayBan,TongTien from DonHangBan", _con);
            dt = new DataTable ();
            da.Fill (dt);
            _con.Close();
            return dt;
        }
        public DataTable GetDonHangBanTKeThang(string thang)
        {
            _con.Open();
            da = new SqlDataAdapter("Select MaDHB, NgayBan,TongTien from DonHangBan where Month(NgayBan)='" + thang + "'", _con);
            dt = new DataTable ();
            da.Fill (dt);
            _con.Close();
            return dt;
        }
        void ThucThiSql (string sql)
        {
            _con.Open ();
            cmd = new SqlCommand (sql, _con);
            cmd.ExecuteNonQuery ();
            _con.Close();
        }
        public int KiemTraMaTrung(string ma)
        {
            _con.Open ();
            int i;
            string sql = "Select count(*) From DonHangBan Where MaDHB = '" + ma.Trim() + "'";
            cmd = new SqlCommand (sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool ThemHD(DonHangBanDTO db)
        {
            string sql = "Insert into DonHangBan values(N'" + db.MaKH + "','" + db.NgayBan + "','" + db.TongTien + "')";
            ThucThiSql(sql);
            return true;
        }
        public bool SuaHD(DonHangBanDTO db)
        {
            string sql = "Update  DonHangBan set MaKH='" + db.MaKH + "', NgayBan='" + db.NgayBan + "', TongTien='" + db.TongTien + "' where MaDHB='" + db.MaDHB + "'";
            ThucThiSql(sql);
            return true;
        }
        public bool XoaHD (string ma)
        {
            string sql = "Delete From DonHangBan where MaDHB = '" + ma + "'";
            ThucThiSql (sql);
            return true;
        }


    }
}
