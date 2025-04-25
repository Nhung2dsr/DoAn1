using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHangBanDTO
    {
        public string MaDHB { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayBan { get; set; }
        public float TongTien { get; set; }
        public DonHangBanDTO()
        {

        }
        public DonHangBanDTO(string MaDHB, string MaKH, DateTime NgayBan, float TongTien)
        {
            this.MaDHB = MaDHB;
            this.MaKH = MaKH;
            this.NgayBan = NgayBan;
            this.TongTien = TongTien;
        }
        public DonHangBanDTO (string MaKH, DateTime NgayBan)
        {
            this.MaKH= MaKH;
            this.NgayBan= NgayBan;
        }
    }
}
