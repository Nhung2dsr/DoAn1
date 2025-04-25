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
    public class NhaCCDAL:DatabaseConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        //Hiển thị danh sách Nhà cung cấp ra màn hình
        public DataTable GetNhaCC()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * From NhaCC",_con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void ThucThiSQL(string sql)
        {
            try
            {
                _con.Open();
                cmd = new SqlCommand(sql, _con);
                cmd.ExecuteNonQuery();
                _con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        
        //Hàm kiểm tra mã trùng
        public int KiemTraMaTrung (string ma)
        {
            _con.Open ();
            int i;
            string sql = "Select count(*) from NhaCC Where MaNCC = '" + ma.Trim() + "'";
            cmd = new SqlCommand(sql,_con);
            i = (int)cmd.ExecuteScalar();   
            _con.Close ();
            return i;
        }
        //Thêm Nhà cung cấp

        public bool ThemNCC(NhaCCDTO nhaCC)
        {
            if (nhaCC == null)
            {
            }
            string sql = "Insert into NhaCC Values ('" + nhaCC.MaNCC + "',N'" + nhaCC.TenNCC + "',N'" + nhaCC.DiaChiNCC + "',N'" + nhaCC.Email + "',N'" + nhaCC.SDT + "')";
            ThucThiSQL(sql);    
            return true;
        }

        //Sửa Nhà cung cấp
        public bool SuaNCC (NhaCCDTO nhaCC)
        {
            string sql = "Update NhaCC SET TenNCC = N'" + nhaCC.TenNCC + "', DiaChi = N'" + nhaCC.DiaChiNCC + "', Email = N'" + nhaCC.Email + "',SDT = N'" + nhaCC.SDT + "' Where MaNCC= '" + nhaCC.MaNCC + "'";
            ThucThiSQL (sql);
            return true;
        }

        //Xóa Nhà cung cấp
        public bool XoaNCC (string ma)
        {
            string sql = "Delete From NhaCC Where MaNCC='" + ma + "'";
            ThucThiSQL(sql);
            return true;
        }
    }
}
