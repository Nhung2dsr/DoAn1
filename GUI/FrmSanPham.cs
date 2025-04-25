using BUS;
using DTO;
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
    public partial class FrmSanPham : Form
    {
        SanPhamBUS spBUS = new SanPhamBUS();
        NhaCCBUS ccBUS = new NhaCCBUS();
        LoaiSanPhamBUS lhBUS = new LoaiSanPhamBUS();

        public FrmSanPham()
        {
            InitializeComponent();


            dtNSX.CustomFormat = "dd/MM/yyyy";
            dtHSD.CustomFormat = "dd/MM/yyyy";
        }


        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = spBUS.GetSanPham();
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbMaNCC.DataSource = ccBUS.GetNhaCC();
            cbMaNCC.DisplayMember = "TenNCC";
            cbMaNCC.ValueMember = "MaNCC";
            cbMaLH.DataSource = lhBUS.GetLoaiHang();                
            cbMaLH.DisplayMember = "TenLoaiSP";      
            cbMaLH.ValueMember = "MaLoaiSP";

        }

        private void FrmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }    
            else
                e.Cancel = true;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaSP.Text = dgvSanPham[0,hang].Value.ToString();
            txtTenSP.Text = dgvSanPham[1,hang].Value.ToString();
            txtSoLuong.Text = dgvSanPham[2,hang].Value.ToString();
            txtDonvt.Text = dgvSanPham[3,hang].Value.ToString();
            cbMaLH.Text = dgvSanPham[4, hang].Value.ToString();
            cbMaNCC.Text = dgvSanPham[5, hang].Value.ToString();
            dtNSX.Text = dgvSanPham[6, hang].Value.ToString();
            dtHSD.Text = dgvSanPham[7, hang].Value.ToString();
            txtMota.Text = dgvSanPham[8, hang].Value.ToString();

            txtMaSP.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaSP = txtMaSP.Text;
            string TenSP = txtTenSP.Text;
            int SoLuong = int.Parse(txtSoLuong.Text);
            string Donvt = txtDonvt.Text;
            string MaLH = cbMaLH.SelectedValue.ToString(); 
            string MaNCC = cbMaNCC.SelectedValue.ToString(); 
            DateTime NSX = DateTime.Parse(dtNSX.Value.ToShortDateString());
            DateTime HSD = DateTime.Parse(dtHSD.Value.ToShortDateString());
            string mota = txtMota.Text;
            SanPhamDTO sp = new SanPhamDTO(MaSP,TenSP,SoLuong, Donvt,MaLH, MaNCC,NSX,HSD,mota);
            if(spBUS.KiemTraMaTrung(MaSP) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (spBUS.ThemSP(sp) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dgvSanPham.DataSource = spBUS.GetSanPham();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {           
                string ma = txtMaSP.Text;
                string ten = txtTenSP.Text;
                string maLH = cbMaLH.Text;
                string maNCC = cbMaNCC.Text;
                int sl = int.Parse(txtSoLuong.Text);
                string dvt = txtDonvt.Text;
                DateTime NSX = DateTime.Parse(dtNSX.Value.ToShortDateString());
                DateTime HSD = DateTime.Parse(dtHSD.Value.ToShortDateString());
                string mota = txtMota.Text;

            SanPhamDTO sp = new SanPhamDTO(ma, ten, sl, dvt, maLH, maNCC, NSX, HSD, mota);
                if (spBUS.SuaSP(sp) == true)
                {
                    MessageBox.Show("Sửa thành công");
                    dgvSanPham.DataSource = spBUS.GetSanPham();
                }           
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaSP.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if(spBUS.XoaSP (ma) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvSanPham.DataSource = spBUS.GetSanPham();
                }    
            }         
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = string.Format("{0} like '{1}'", "TenSP", "*" + txtTimKiem.Text + "*");
            (dgvSanPham.DataSource as DataTable).DefaultView.RowFilter = key;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "";
            txtDonvt.Text = "";
            txtTimKiem.Text = "";
            dtNSX.Text = "";
            dtHSD.Text = "";
            txtMota.Text = "";
            btnThem.Enabled = true;
            txtMaSP.Enabled = true;
            btnLamMoi.Enabled = true;
            dgvSanPham.DataSource = spBUS.GetSanPham ();
        }

        
    }

}
