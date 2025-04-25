using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhapDTO
    {
        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }   
        public DangNhapDTO()
        {

        }
        public DangNhapDTO(string ten, string mk, string email)
        {
            this.TenTK = ten;
            this.MatKhau = mk;
            this.Email = email;
        }
        public DangNhapDTO(string mk, string email)
        {
            this.MatKhau = mk;
            this.Email = email;  
        }
    }
}