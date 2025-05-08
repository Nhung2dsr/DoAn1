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
    public partial class FrmLoaiSanPham : Form
    {
        LoaiSanPhamBUS buslh = new LoaiSanPhamBUS();
        public FrmLoaiSanPham()
        {
            InitializeComponent();
        }
        private void FrmLoaiHang_Load_1(object sender, EventArgs e)
        {
            dgvLoaiHang.DataSource = buslh.GetLoaiHang();
            dgvLoaiHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void dgvLoaiHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaLH.Text = dgvLoaiHang[0, hang].Value.ToString();
            txtTenLH.Text = dgvLoaiHang[1, hang].Value.ToString();
 
            txtMaLH.Enabled = false;
            btnThem.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaLH.Text;
                string ten = txtTenLH.Text;
                // Kiểm tra nếu bất kỳ ô nào trống
                if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LoaiSanPhamDTO loaihang = new LoaiSanPhamDTO(ma, ten);
                if (buslh.KiemTraMaTrung(ma) == 1)
                {
                    MessageBox.Show("Mã trùng");
                }

                else
                {
                    if (buslh.ThemLoaiSP(loaihang) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvLoaiHang.DataSource = buslh.GetLoaiHang();
                        txtMaLH.Text = "";
                        txtTenLH.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string ma = txtMaLH.Text;
            string ten = txtTenLH.Text;
            LoaiSanPhamDTO lh = new LoaiSanPhamDTO(ma, ten);

            if (buslh.SuaLoaiSP(lh) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgvLoaiHang.DataSource = buslh.GetLoaiHang();
            }
        }

        private void FrmLoaiHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rt = MessageBox.Show("Bạn có muốn thoát không!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rt == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = string.Format("{0} like '{1}'", "TenLoaiSP", "*" + txtTimKiem.Text + "*");
            (dgvLoaiHang.DataSource as DataTable).DefaultView.RowFilter = key;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLH.Text = "";
            txtTenLH.Text = "";
            txtTimKiem.Text = "";
            txtMaLH.Enabled = true;
            btnThem.Enabled = true;
            dgvLoaiHang.DataSource = buslh.GetLoaiHang();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaLH.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (buslh.XoaLoaiSP(ma) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvLoaiHang.DataSource = buslh.GetLoaiHang();
                }
            }
        }

        private void dgvLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
