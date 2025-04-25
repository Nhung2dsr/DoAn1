using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DangNhapDAL:DatabaseConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable GetTaiKhoan()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from TaiKhoan", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable GetMK()
        {
            _con.Open();
            da = new SqlDataAdapter("Select MatKhau from TaiKhoan", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public void ThucThiSQL(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public int KiemTraTaiKhoan(string tentk, string mk)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from TaiKhoan where TenTaiKhoan='" + tentk.Trim() + "' and MatKhau='" + mk.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public int KiemTraEmailMatKhau(string email, string mk)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from TaiKhoan where Email='" + email.Trim() + "' and MatKhau='" + mk.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public int KiemTraEmail(string email)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from TaiKhoan where Email='" + email.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
        public bool SuaMK(DangNhapDTO dn)
        {
            string sql = "Update TaiKhoan set MatKhau=N'" + dn.MatKhau + "' where Email='" + dn.Email + "'";

            ThucThiSQL(sql);
            return true;
        }

    }
}
