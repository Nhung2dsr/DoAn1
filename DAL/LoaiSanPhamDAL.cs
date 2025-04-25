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
    public class LoaiSanPhamDAL:DatabaseConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        // Hiển thị danh sách loại sản phẩm ra ngoài màn hình
        public DataTable GetLoaiSP()
        {
            _con.Open();
            da = new SqlDataAdapter("Select*from LoaiSanPham", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void ThucThiSQL (string sql)
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
            string sql = "Select count(*) from LoaiSanPham WHERE MaLoaiSP = '" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }

        //Thêm loại sản phẩm
        public bool ThemLoaiSP(LoaiSanPhamDTO lh)
        {
            string sql = "Insert into LoaiSanPham values('" + lh.MaLoaiSP + "',N'" + lh.TenLoaiSP + "')";

            ThucThiSQL(sql);
            return true;
        }

        //Sửa loại sản phẩm
        public bool SuaLoaiSP(LoaiSanPhamDTO lh)
        {
            string sql = "Update LoaiSanPham set TenLoaiSP = N'" + lh.TenLoaiSP + "' where MaLoaiSP ='" + lh.MaLoaiSP + "'";

            ThucThiSQL(sql);
            return true;
        }

        //Xóa loại sản phẩm
        public bool XoaLoaiSP(string ma)
        {
            string sql = "Delete from LoaiSanPham where MaLoaiSP='" + ma + "'";
            ThucThiSQL(sql);
            return true;
        }
    }
}
