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
        public string MaDHB { get; set; }
        public string MaMH { get; set; }
        public string DvTinh { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public ChiTietDHBDTO()
        {

        }

        public ChiTietDHBDTO(string MaCTB, string MaDHB, string MaMH, string dvt, int sl, float dg, float thanhTien)
        {
            this.MaCTB = MaCTB;
            this.MaDHB = MaDHB;
            this.MaMH = MaMH;
            this.DvTinh = dvt;
            this.SoLuong = sl;
            this.DonGia = dg;
            this.ThanhTien = thanhTien;
        }
    }
}
