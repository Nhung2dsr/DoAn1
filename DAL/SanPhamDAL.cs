using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Security.RightsManagement;
using System.Windows.Forms;
namespace DAL
{
    public class SanPhamDAL : DatabaseConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        //Hiển thị danh sách sản phẩm ra màn hình
        public DataTable GetSanPham()
        {
            _con.Open();
            da = new SqlDataAdapter("Select*From SanPham", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable GetSanPhamSL(string ma)
        {
            _con.Open();
            da = new SqlDataAdapter("Select SoLuong from SanPham where MaSP='" + ma + "'", _con);
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
        public int KiemTraMaTrung(string maSP)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from SanPham Where MaSP = '" + maSP.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }

        //Thêm Sản phẩm
        public bool ThemSP(SanPhamDTO sp)
        {
            string sql = "Insert into SanPham values('" + sp.MaSP + "',N'" + sp.TenSP + "','" + sp.SoLuong + "',N'" + sp.DonViTinh + "','" + sp.MaLoaiSP + "','" + sp.MaNCC + "','" + sp.NgaySX + "','" + sp.HSD + "',N'" + sp.MoTa + "')";
            ThucThiSql(sql);
            return true;
        }

        //Sửa Sản phẩm
        public bool SuaSP(SanPhamDTO sp)
        { 
            string sql = "Update SanPham set TenSP=N'" + sp.TenSP + "', MaLoaiSP='" + sp.MaLoaiSP + "', MaNCC='" + sp.MaNCC + "', SoLuong='" + sp.SoLuong + "', DonViTinh=N'" + sp.DonViTinh + "', NSX = '" + sp.NgaySX + "',HSD = '" + sp.HSD + "', MoTa = N'" + sp.MoTa + "' where MaSP='" + sp.MaSP + "'";
            ThucThiSql(sql);
            return true;
        }

        //Xóa Sản phẩm
        public bool XoaSP(string ma)
        {
            string sql = "Delete From SanPham Where MaSP = '" + ma + "'";
            ThucThiSql(sql);
            return true;
        }
    }
}
