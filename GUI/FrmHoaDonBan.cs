using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmHoaDonBan : Form
    {
        public FrmHoaDonBan()
        {
            InitializeComponent();
        }
        public int MaDHB;
        private void FrmHoaDonBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inHoaDonBan.HoaDonBanIn' table. You can move, or remove it, as needed.
            this.hoaDonBanInTableAdapter1.Fill(this.inHoaDonBan.HoaDonBanIn,MaDHB);

            this.reportViewer1.RefreshReport();
        }
    }
}
