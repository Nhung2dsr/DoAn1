using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class KhachHangDAL : DatabaseConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        //Hiển thị danh sách khách hàng ra màn hình
        public DataTable GetKhachHang()
        {
            _con.Open();
            da = new SqlDataAdapter("Select*From KhachHang", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void ThucThiSql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }

        //Hàm kiểm tra mã trùng
        public int KiemTraMaTrung(string ma)
        {
            _con.Open();
            int i;
            string sql = ("Select count(*) from KhachHang Where MaKH = '" + ma.Trim() + "'");
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }

        //Thêm Khách hàng
        public bool ThemKH(KhachHangDTO KhachHang)
        {
            string sql = "Insert into KhachHang Values ('" + KhachHang.MaKH + "', N'" + KhachHang.TenKH + "',N'" + KhachHang.DiaChi + "',N'" + KhachHang.Email + "','" + KhachHang.SDT + "')";
            ThucThiSql(sql);
            return true;
        }
        
        // Sửa Khách Hàng
        public bool SuaKH(KhachHangDTO KhachHang)
        {
            string sql = "Update KhachHang SET TenKH = N'" + KhachHang.TenKH + "', DiaChi= N'" + KhachHang.DiaChi + "',Email= N'" + KhachHang.Email + "',SDT = '" + KhachHang.SDT + "' Where MaKH = '" + KhachHang.MaKH + "'";
            ThucThiSql(sql);
            return true;
        }

        // Xóa Khách hàng
        public bool XoaKH (string ma)
        {
            string sql = "Delete From KhachHang Where MaKH = '" + ma + "'";
            ThucThiSql(sql);
            return true;
        }
    }
}
