using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDHNDTO
    {
        public string MaCTN { get; set; }
        public string MaDHN { get; set; }
        public string MaMH { get; set; }
        public string DvTinh { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public ChiTietDHNDTO()
        {

        }

        public ChiTietDHNDTO (string maCT,string MaDHN, string MaMH, string dvt,int sl,float dg,float thanhTien)
        {
            this.MaCTN = maCT;
            this.MaDHN = MaDHN;
            this.MaMH = MaMH;
            this.DvTinh = dvt;
            this.SoLuong = sl;
            this.DonGia = dg;
            this.ThanhTien = thanhTien;
        }

    }
}
