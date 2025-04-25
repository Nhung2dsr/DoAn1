using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHangNhapDTO
    {
        public string MaDHN { get; set; }
        public string MaNCC { get; set; }
        public DateTime NgayNhap {  get; set; }
        public float TongTien { get; set; }

        public DonHangNhapDTO()
        {

        }
        public DonHangNhapDTO (string MaDHN, string MaNCC, DateTime NgayNhap, float TongTien)
        {
            this.MaDHN = MaDHN;
            this.MaNCC = MaNCC;
            this.NgayNhap = NgayNhap;
            this.TongTien = TongTien;
        }
        public DonHangNhapDTO (string MaNCC, DateTime NgayNhap)
        {
            this.MaNCC= MaNCC;
            this.NgayNhap= NgayNhap;
        }
    }
}
