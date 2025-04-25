using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKH {  get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; } 
        public KhachHangDTO()
        { 

        }
        public KhachHangDTO(string ma,string ten,string diac,string email,string sdt)
        {
            MaKH = ma;
            TenKH = ten;
            DiaChi = diac;
            Email = email;
            SDT = sdt;
        }
    }
}
