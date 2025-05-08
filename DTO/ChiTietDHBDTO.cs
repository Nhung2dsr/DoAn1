using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDHBDTO
    {
        public string MaCTB { get; set; }
        public int MaDHB { get; set; }
        public string MaSP { get; set; }
        public string DvTinh { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public ChiTietDHBDTO()
        {

        }

        public ChiTietDHBDTO(string MaCTB, int MaDHB, string MaSP, string dvt, int sl, float dg, float thanhTien)
        {
            this.MaCTB = MaCTB;
            this.MaDHB = MaDHB;
            this.MaSP = MaSP;
            this.DvTinh = dvt;
            this.SoLuong = sl;
            this.DonGia = dg;
            this.ThanhTien = thanhTien;
        }
    }
}
