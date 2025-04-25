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
    public class ChiTietDHBDAL: DatabaseConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        //Hiển thị danh sách Chi tiết đơn hàng bán
        public DataTable GetChiTietDHB()
        {
            _con.Open();
            da = new SqlDataAdapter("Select*From ChiTietDHB", _con);
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
            string sql = "Select count(*) from ChiTietDHB WHERE MaCTB = '" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }

        //Thêm Chi Tiết Đơn Hàng Bán
        public bool ThemCTB(ChiTietDHBDTO ctb)
        {
            string sql = "Insert into ChiTietDHB values('" + ctb.MaCTB + "','" + ctb.MaMH + "','" + ctb.MaDHB + "',N'" + ctb.DvTinh + "','" + ctb.SoLuong + "','" + ctb.DonGia + "','" + ctb.ThanhTien + "')";
            ThucThiSql(sql);
            return true;
        }
        public bool SuaCTB(ChiTietDHBDTO ctb)
        {
            string sql = "Update ChiTietDHB set DvTinh=N'" + ctb.DvTinh + "', SoLuong='" + ctb.SoLuong + "', DonGia='" + ctb.DonGia + "', ThanhTien='" + ctb.ThanhTien + "' where MaCTB='" + ctb.MaCTB + "'";
            ThucThiSql(sql);
            return true;
        }
        public bool XoaCTB(string ma)
        {
            string sql = "Delete From ChiTietDHB Where MaCTB = '" + ma + "'";
            ThucThiSql(sql);
            return true;
        }
        public bool XoaHD(string ma)
        {
            string sql = "Delete From ChiTietDHB Where MaDHB = '" + ma + "'";
            ThucThiSql(sql);
            return true;
        }
        public DataTable GetSpByMaB(string mab)
        {
            _con.Open();
            da = new SqlDataAdapter("Select*From ChiTietDHB Where MaDHB = '" + mab + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable TachMa(string ma)
        {
            _con.Open();
            da = new SqlDataAdapter("Select*From ChiTietDHB Where MaDHB Like N'" + "%" + ma + "%" + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
