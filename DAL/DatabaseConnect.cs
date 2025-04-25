using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;



namespace DAL
{
    public class DatabaseConnect
    {
        public SqlConnection _con = new SqlConnection(@"Data Source=DESKTOP-NCC06AH\SQLEXPRESS01;Initial Catalog=QLMiPham;Integrated Security=True");
    }
}
