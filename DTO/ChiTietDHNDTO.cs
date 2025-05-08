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
        public int MaDHN { get; set; }
        public string MaSP { get; set; }
        public string DvTinh { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public ChiTietDHNDTO()
        {

        }

        public ChiTietDHNDTO (string maCT,int MaDHN, string MaSP, string dvt,int sl,float dg,float thanhTien)
        {
            this.MaCTN = maCT;
            this.MaDHN = MaDHN;
            this.MaSP = MaSP;
            this.DvTinh = dvt;
            this.SoLuong = sl;
            this.DonGia = dg;
            this.ThanhTien = thanhTien;
        }

    }
}
