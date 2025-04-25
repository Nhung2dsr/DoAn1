using GUI.InHoaDonNhapTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class FrmHoaDonNhap : Form
    {
        public FrmHoaDonNhap()
        {
            InitializeComponent();
        }
        

        

        
        public int MaDHN;
       
       
        private void FrmHoaDonNhap_Load(object sender, EventArgs e)
        {

            this.hoaDonNhapInTableAdapter.Fill(this.inHoaDonNhap.HoaDonNhapIn,MaDHN);
            this.reportViewer1.RefreshReport();


        }

        
    }
}
