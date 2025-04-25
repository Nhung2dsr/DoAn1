using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class NhaCCBUS
    {
        NhaCCDAL ccDAL = new NhaCCDAL();
        public DataTable GetNhaCC()
        {
            return ccDAL.GetNhaCC();
        }
        public int KiemTraMaTrung(string ma)
        {
            return ccDAL.KiemTraMaTrung(ma);
        }
        public bool ThemNCC (NhaCCDTO nhaCC)
        {
            return ccDAL.ThemNCC(nhaCC);
        }
        public bool SuaNCC (NhaCCDTO nhaCC)
        {
            return ccDAL.SuaNCC(nhaCC);
        }
        public bool XoaNCC (string ma)
        {
            return ccDAL.XoaNCC(ma) ;
        }
    }
}
