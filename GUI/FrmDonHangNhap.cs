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
using System.Data.SqlClient;
using DTO;
using Microsoft.IdentityModel.Tokens;

namespace GUI
{
    public partial class FrmDonHangNhap : Form
    {
        ChiTietDHNBUS ctnBUS = new ChiTietDHNBUS();
        DonHangNhapBUS dnBUS = new DonHangNhapBUS();
        NhaCCBUS ccBUS = new NhaCCBUS();
        SanPhamBUS spBUS = new SanPhamBUS();

        public FrmDonHangNhap()
        {
            InitializeComponent();
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
        }
        private void LoadDataGridView()
        {
            dgvDSHD.Columns[0].HeaderText = "Mã HDN";
            dgvDSHD.Columns[1].HeaderText = "Mã NCC";
            dgvDSHD.Columns[2].HeaderText = "Ngày Nhập";
            dgvDSHD.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSHD.Columns[3].HeaderText = "Tổng Tiền";
            dgvDSHD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void FrmDonHangNhap_Load(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = dnBUS.GetDonHangNhap();
            dgvChiTietNhap.DataSource = ctnBUS.GetChiTietNhap();
            dgvDSHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtMaDHN.Enabled = false; 
            cbMaNCC.DataSource = ccBUS.GetNhaCC();
            cbMaNCC.DisplayMember = "TenNCC";
            cbMaNCC.ValueMember = "MaNCC";
            cbMaSP.DataSource = spBUS.GetSanPham();
            cbMaSP.DisplayMember = "TenSP";
            cbMaSP.ValueMember = "MaSP";
            txtThanhTien.Enabled = false;
            cbMaHDN.DataSource = dnBUS.GetDonHangNhap();
            cbMaHDN.DisplayMember = "MaDHN";
            txtMaCT.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;
            txtDvt.Enabled = false;
            LoadDataGridView();

        }

        private void FrmDonHangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaDHN.Text = dgvDSHD[0, hang].Value.ToString();
            cbMaNCC.SelectedValue = dgvDSHD[1, hang].Value.ToString();
            dtpNgayNhap.Text = dgvDSHD[2, hang].Value.ToString();
            txtTongTien.Text = dgvDSHD[3, hang].Value.ToString();
            txtMaDHN.Enabled = false;
            DataTable listDHN = new DataTable(); //Khởi tạo 
            listDHN = ctnBUS.GetSpByMaN(txtMaDHN.Text);
            dgvChiTietNhap.DataSource = listDHN;
            btnThem.Enabled = false;
            txtMaCT.Enabled = true;
            txtDvt.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaDHN.Text;
            string mancc = cbMaNCC.SelectedValue.ToString();
            DateTime ngaynhap = DateTime.Parse(dtpNgayNhap.Value.ToShortDateString());
            float tongtien = float.Parse(txtTongTien.Text = "0");
            DonHangNhapDTO dn = new DonHangNhapDTO(ma, mancc, ngaynhap, tongtien);
            if (dnBUS.KiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (dnBUS.ThemHD(dn) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dgvDSHD.DataSource = dnBUS.GetDonHangNhap();
                    cbMaHDN.DataSource = dnBUS.GetDonHangNhap();
                    cbMaHDN.DisplayMember = "MaDHN";
                }
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = string.Format("Convert(MaDHN, 'System.String') LIKE '%{0}%'", txtTimKiem.Text.Trim());
            (dgvDSHD.DataSource as DataTable).DefaultView.RowFilter = key;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaDHN.Text;
            string ncc = cbMaNCC.SelectedValue.ToString();
            DateTime nn = DateTime.Parse(dtpNgayNhap.Value.ToShortDateString());
            float tongtien = float.Parse(txtTongTien.Text);
            DonHangNhapDTO dn = new DonHangNhapDTO(ma, ncc, nn, tongtien);

            if (dnBUS.SuaHD(dn) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgvDSHD.DataSource = dnBUS.GetDonHangNhap();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaDHN.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (dnBUS.XoaHD(ma) == true && ctnBUS.XoaHD(ma) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvChiTietNhap.DataSource = ctnBUS.GetChiTietNhap();
                    dgvDSHD.DataSource = dnBUS.GetDonHangNhap();
                    cbMaHDN.DataSource = dnBUS.GetDonHangNhap();
                    cbMaHDN.DisplayMember = "MaDHN";
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDHN.Text = "";
            cbMaNCC.Text = "";
            dtpNgayNhap.Text = "";
            txtTongTien.Text = "";
            txtMaCT.Text = "";
            txtMaDHN.Text = "";
            txtDvt.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
            txtMaDHN.Enabled = true;
            btnLamMoi.Enabled = true;
            btnThem.Enabled = true;
            btnThemCT.Enabled = true;
            txtTimKiem.Text = "";
            dgvDSHD.DataSource = dnBUS.GetDonHangNhap();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ma = txtMaDHN.Text;
            string ncc = cbMaNCC.SelectedValue.ToString();
            DateTime nn = DateTime.Parse(dtpNgayNhap.Value.ToShortDateString());
            float tongtien = float.Parse(txtTongTien.Text);
            DonHangNhapDTO hdn = new DonHangNhapDTO(ma, ncc, nn, tongtien);

            if (dnBUS.SuaHD(hdn) == true)
            {
                MessageBox.Show("Lưu thành công");
                dgvDSHD.DataSource = dnBUS.GetDonHangNhap();
            }
        }

        private void dgvChiTietNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;

            txtMaCT.Text = dgvChiTietNhap[0, hang].Value.ToString();
            cbMaSP.SelectedValue = dgvChiTietNhap[2, hang].Value.ToString();
            cbMaHDN.Text = dgvChiTietNhap[1, hang].Value.ToString();
            txtDvt.Text = dgvChiTietNhap[3, hang].Value.ToString();
            txtSoLuong.Text = dgvChiTietNhap[4, hang].Value.ToString();
            txtDonGia.Text = dgvChiTietNhap[5, hang].Value.ToString();
            txtThanhTien.Text = dgvChiTietNhap[6, hang].Value.ToString();
            txtMaCT.Enabled = false;
            btnThemCT.Enabled = false;
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaCT.Text;
                string maSP = cbMaSP.SelectedValue.ToString();
                int maDHN = int.Parse(cbMaHDN.Text);
                string dvt = txtDvt.Text;
                int SoLuong = int.Parse(txtSoLuong.Text);
                float dg = float.Parse(txtDonGia.Text);
                float ThanhTien = SoLuong * dg;
                txtThanhTien.Text = ThanhTien.ToString();
                // Kiểm tra nếu bất kì ô nào trống
                if (string.IsNullOrEmpty(dvt) || string.IsNullOrEmpty(txtSoLuong.Text) || string.IsNullOrEmpty(txtDonGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }    
                
                ChiTietDHNDTO ctn = new ChiTietDHNDTO(ma,maDHN, maSP, dvt, SoLuong, dg, ThanhTien);
                if (ctnBUS.KiemTraMaTrung(ma) == 1)
                {
                    MessageBox.Show("Mã chi tiết trùng");
                }
                else
                {
                    if (ctnBUS.ThemCTN(ctn) == true)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvChiTietNhap.DataSource = ctnBUS.GetChiTietNhap();
                        DataTable listDHN = new DataTable(); //Khởi tạo 
                        listDHN = ctnBUS.GetSpByMaN(txtMaDHN.Text);
                        dgvChiTietNhap.DataSource = listDHN;
                        int tong = 0;
                        for (int i = 0; i < dgvChiTietNhap.Rows.Count; ++i)
                        {
                            tong += Convert.ToInt32(dgvChiTietNhap.Rows[i].Cells[6].Value);

                        }
                        txtTongTien.Text = tong.ToString();
                        int rowIndex = dgvDSHD.CurrentCell.RowIndex;
                        DataGridViewRow selectedRow = dgvDSHD.Rows[rowIndex];
                        string value = txtTongTien.Text;
                        selectedRow.Cells[3].Value = value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void btnSuaCTN_Click(object sender, EventArgs e)
        {
            string ma = txtMaCT.Text;
            string maSP = cbMaSP.SelectedValue.ToString();
            int maDHN = int.Parse(cbMaHDN.Text);
            string dvt = txtDvt.Text;
            int SoLuong = int.Parse(txtSoLuong.Text);
            float dg = float.Parse(txtDonGia.Text);
            float ThanhTien = SoLuong * dg;
            txtThanhTien.Text = ThanhTien.ToString();

            ChiTietDHNDTO ctn = new ChiTietDHNDTO(ma, maDHN, maSP, dvt, SoLuong, dg, ThanhTien);
            if (ctnBUS.SuaCTN(ctn) == true)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvChiTietNhap.DataSource = ctnBUS.GetChiTietNhap();
                DataTable listDHN = new DataTable(); //Khởi tạo
                listDHN = ctnBUS.GetSpByMaN(cbMaHDN.Text);
                dgvChiTietNhap.DataSource = listDHN;
                int tong = 0;
                for (int i = 0; i < dgvChiTietNhap.Rows.Count; i++)
                {
                    tong += Convert.ToInt32(dgvChiTietNhap.Rows[i].Cells[6].Value);
                }
                txtTongTien.Text = tong.ToString();
                int rowIndex = dgvDSHD.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgvDSHD.Rows[rowIndex];
                string value = txtTongTien.Text;
                selectedRow.Cells[3].Value = value;
                btnThemCT.Enabled = true;
            }
        }

        private void btnXoaCTN_Click(object sender, EventArgs e)
        {
            string ma = txtMaCT.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (ctnBUS.XoaCTN(ma) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvChiTietNhap.DataSource = ctnBUS.GetChiTietNhap();
                    DataTable listDHN = new DataTable(); //Khởi tạo 
                    listDHN = ctnBUS.GetSpByMaN(txtMaDHN.Text);
                    dgvChiTietNhap.DataSource = listDHN;
                    int tong = 0;
                    for (int i = 0; i < dgvChiTietNhap.Rows.Count; ++i)
                    {
                        tong += Convert.ToInt32(dgvChiTietNhap.Rows[i].Cells[6].Value);

                    }
                    txtTongTien.Text = tong.ToString();
                    int rowIndex = dgvDSHD.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dgvDSHD.Rows[rowIndex];
                    string value = txtTongTien.Text;
                    selectedRow.Cells[3].Value = value;
                    btnThemCT.Enabled = true;
                }
            }
        }

        private void btnLamMoiCT_Click(object sender, EventArgs e)
        {
            txtMaCT.Text = "";
            txtMaCT.Enabled = true;
            txtDvt.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
            btnThemCT.Enabled = true;
            btnSuaCTN.Enabled = true;
            btnXoaCTN.Enabled = true;
            dgvDSHD.DataSource = dnBUS.GetDonHangNhap();
        }
    

        private void btnInHoaDonNhap_Click_1(object sender, EventArgs e)
        {
            FrmHoaDonNhap frmInHoaDonNhap = new FrmHoaDonNhap();

            if (int.TryParse(txtMaDHN.Text.Trim(), out int maHDN)) // Chuyển đổi string sang int
            {
                frmInHoaDonNhap.MaDHN = maHDN;
                frmInHoaDonNhap.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mã hóa đơn nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
    }
}
    
