using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public string MaSP {  get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public string MaLoaiSP {  get; set; }
        public string MaNCC { get; set; }
        public DateTime NgaySX { get; set; }
        public DateTime HSD { get; set; }
        public string MoTa {  get; set; }
        public string TenLoaiSP { get; set; }
        public SanPhamDTO() 
        { 

        }
        public SanPhamDTO(string ma, string ten, int sl, string dvt, string maLH, string maNCC,DateTime nsx,DateTime hsd,string mota)
        {
            this.MaSP = ma;
            this.TenSP = ten;
            this.SoLuong = sl;
            this.DonViTinh = dvt;
            this.MaLoaiSP = maLH;
            this.MaNCC = maNCC;
            this.NgaySX = nsx;
            this.HSD = hsd;
            this.MoTa = mota;
        }


    }
}
