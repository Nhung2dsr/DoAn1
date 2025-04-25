using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPhamDTO
    {
        public string MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }
        

        public LoaiSanPhamDTO()
        {

        }

        public LoaiSanPhamDTO (string maLH, string tenLH)
        {
            MaLoaiSP = maLH;
            TenLoaiSP = tenLH;
            
        }
    }
  
}
