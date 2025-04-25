using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Data.SqlClient;


namespace GUI
{
    public partial class FrmKhachHang : Form
    {
        KhachHangBUS khBUS = new KhachHangBUS();
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaKH.Text = dgvKH[0,hang].Value.ToString();
            txtTenKH.Text = dgvKH[1,hang].Value.ToString();
            txtDCKH.Text = dgvKH[2,hang].Value.ToString();
            txtEmailKH.Text = dgvKH[3,hang].Value.ToString();
            txtSoDTKH.Text  = dgvKH[4,hang].Value.ToString();
            txtMaKH.Enabled = false;
            btnThem.Enabled = false;

        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = khBUS.GetKhachHang();
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaKH.Text;
            string ten = txtTenKH.Text;
            string DiaChi = txtDCKH.Text;
            string Email = txtEmailKH.Text;
            string SDT = txtSoDTKH.Text;
            KhachHangDTO KhachHang = new KhachHangDTO(ma,ten,DiaChi,Email,SDT);
            if (khBUS.KiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã trùng");
            }    
            else
            {
                if(khBUS.ThemKH(KhachHang) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dgvKH.DataSource = khBUS.GetKhachHang();
                    txtMaKH.Text = "";
                    txtTenKH.Text = "";
                    txtDCKH.Text = "";
                    txtEmailKH.Text = "";
                    txtSoDTKH.Text= "";
                }    
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaKH.Text;
            string ten = txtTenKH.Text;
            string DiaChi = txtDCKH.Text;
            string Email = txtEmailKH.Text;
            string SDT = txtSoDTKH.Text;
            KhachHangDTO KhachHang = new KhachHangDTO(ma,ten, DiaChi, Email, SDT);
            if (khBUS.SuaKH(KhachHang) == true )
            {
                MessageBox.Show("Sửa thành công");
                dgvKH.DataSource = khBUS.GetKhachHang();
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKH.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn muốn thoát không?","Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (khBUS.XoaKH(ma) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvKH.DataSource = khBUS.GetKhachHang();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDCKH.Text = "";
            txtEmailKH.Text = "";
            txtSoDTKH.Text = "";
            txtMaKH.Enabled = true;
            btnLamMoi.Enabled = true;
            btnThem.Enabled = true;
            dgvKH.DataSource = khBUS.GetKhachHang();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = string.Format("{0} like '{1}'", "SDT", "*" + txtTimKiem.Text + "*");
            (dgvKH.DataSource as DataTable).DefaultView.RowFilter = key;
        }

        private void FrmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) 
                e.Cancel = false;
            else 
                e.Cancel = true;
        }

        //private void btnInDanhSach_Click(object sender, EventArgs e)
        //{
        //    FrmXuatDSKhachHang frmXuatKhachHang = new FrmXuatDSKhachHang();
        //    frmXuatKhachHang.ShowDialog();
        //}
    }
}
