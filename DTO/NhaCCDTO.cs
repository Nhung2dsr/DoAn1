using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCCDTO
    {
        public string MaNCC {  get; set; }
        public string TenNCC { get; set; }
        public string DiaChiNCC { get;set;}
        public string Email {  get; set; }
        public string SDT { get; set; }
        public NhaCCDTO() 
        {

        }
        public NhaCCDTO(string ma, string ten, string diac, string email, string sdt)
        {
            MaNCC = ma;
            TenNCC = ten;
            DiaChiNCC = diac;
            Email = email;
            SDT = sdt;
        }
    }
}
