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
    public class ChiTietDHNDAL : DatabaseConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        //Hiển thị danh sách Chi tiết đơn hàng nhập
        public DataTable GetChiTietDHN()
        {
            _con.Open();
            da = new SqlDataAdapter("Select*From ChiTietDHN", _con);
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

        //Kiểm tra mã trùng
        public int KiemTraMaTrung(string ma)
        {
            _con.Open();
            int i;
            string sql = "Select count(*) from ChiTietDHN WHERE MaCTN = '" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }

        //Thêm Chi Tiết Đơn Hàng Nhập
        public bool ThemCTN(ChiTietDHNDTO ctn)
        {
            string sql = "Insert into ChiTietDHN values('" + ctn.MaCTN + "', '" + ctn.MaSP + "','" + ctn.MaDHN + "',N'" + ctn.DvTinh + "','" + ctn.SoLuong + "','" + ctn.DonGia + "','" + ctn.ThanhTien + "')";
            ThucThiSql(sql);
            return true;
        }
        public bool SuaCTN(ChiTietDHNDTO ctn)
        {
            string sql = "UPDATE ChiTietDHN SET " +
             "MaDHN = N'" + ctn.MaDHN + "', " +
             "MaSP = '" + ctn.MaSP + "', " + 
             "DvTinh = N'" + ctn.DvTinh + "', " +
             "SoLuong = " + ctn.SoLuong + ", " +
             "DonGia = " + ctn.DonGia + ", " +
             "ThanhTien = " + ctn.ThanhTien + " " +
             "WHERE MaCTN = '" + ctn.MaCTN + "'";
            ThucThiSql(sql);
            return true;
        }
            
        
        public bool XoaCTN(string ma)
        {
            string sql = "Delete From ChiTietDHN Where MaCTN = '" + ma + "'";
            ThucThiSql(sql);
            return true;
        }
        public bool XoaHD(string ma)
        {
            string sql = "Delete From ChiTietDHN Where MaDHN = '" + ma + "'";
            ThucThiSql(sql);
            return true;
        }
        public DataTable GetSpByMaN(string man)
        {
            _con.Open();
            da = new SqlDataAdapter("Select*From ChiTietDHN Where MaDHN = '" + man + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable TachMa (string ma)
        {
            _con.Open();
            da = new SqlDataAdapter("Select*From ChiTietDHN Where MaDHN Like N'" + "%" + ma + "%" + "'",_con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }




    }
}

