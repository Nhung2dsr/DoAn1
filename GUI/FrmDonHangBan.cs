using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Data.SqlClient;
using System.Net;


namespace GUI
{
    public partial class FrmDonHangBan : Form
    {
        DonHangBanBUS dbBUS = new DonHangBanBUS();
        ChiTietDHBBUS ctbBUS = new ChiTietDHBBUS();
        KhachHangBUS khBUS  = new KhachHangBUS();
        SanPhamBUS spBUS = new SanPhamBUS();
        public FrmDonHangBan()
        {
            InitializeComponent();
            dtpNgayBan.CustomFormat = "dd/MM/yyyy";
           
        }
        private void LoadDataGridView()
        {
            dgvDSHD.Columns[0].HeaderText = "Mã HDB";
            dgvDSHD.Columns[1].HeaderText = "Mã KH";
            dgvDSHD.Columns[2].HeaderText = "Ngày Bán";
            dgvDSHD.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSHD.Columns[3].HeaderText = "Tổng Tiền";
            dgvDSHD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
     

        private void FrmDonHangBan_Load(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = dbBUS.GetDonHangBan();
            dgvDSHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtMaDHB.Enabled = false;
            cbMaKH.DataSource = khBUS.GetKhachHang();
            cbMaKH.DisplayMember = "TenKH";
            cbMaKH.ValueMember = "MaKH";
            cbMaSP.DataSource = spBUS.GetSanPham();
            cbMaSP.DisplayMember = "TenSP";
            cbMaSP.ValueMember = "MaSP";
            cbMaDHB.DataSource = dbBUS.GetDonHangBan();
            cbMaDHB.DisplayMember = "MaDHB";
            dgvChiTietBan.DataSource = ctbBUS.GetChiTietBan();
            dgvChiTietBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtMaCT.Enabled = false;
            txtSoLuong.Enabled = false;
            LoadDataGridView();
        }

        private void FrmDonHangBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
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
            txtMaDHB.Text = dgvDSHD[0, hang].Value.ToString();
            cbMaKH.SelectedValue = dgvDSHD[1,hang].Value.ToString();
            dtpNgayBan.Text = dgvDSHD[2,hang].Value.ToString();
            txtTongTien.Text = dgvDSHD[3,hang].Value.ToString();
            txtMaDHB.Enabled = false;
            DataTable listDHB = new DataTable(); //Khởi tạo 
            listDHB = ctbBUS.GetSpByMaB(txtMaDHB.Text);
            dgvChiTietBan.DataSource = listDHB;
            btnThem.Enabled = false;
            txtMaCT.Enabled = true;
            txtSoLuong.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaDHB.Text;
            string makh = cbMaKH.SelectedValue.ToString();
            DateTime ngayban = DateTime.Parse(dtpNgayBan.Value.ToShortDateString());
            float tongtien = float.Parse(txtTongTien.Text = "0");
            DonHangBanDTO db = new DonHangBanDTO(ma, makh, ngayban, tongtien);
            if (dbBUS.KiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (dbBUS.ThemHD(db) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dgvDSHD.DataSource = dbBUS.GetDonHangBan();
                    cbMaDHB.DataSource = dbBUS.GetDonHangBan();
                    cbMaDHB.DisplayMember = "MaDHB";
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaDHB.Text;
            string nkh = cbMaKH.SelectedValue.ToString();
            DateTime nb = DateTime.Parse(dtpNgayBan.Value.ToShortDateString());
            float tongtien = float.Parse(txtTongTien.Text);
            DonHangBanDTO db = new DonHangBanDTO(ma, nkh, nb, tongtien);

            if (dbBUS.SuaHD(db) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgvDSHD.DataSource = dbBUS.GetDonHangBan();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaDHB.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (dbBUS.XoaHD(ma) == true && ctbBUS.XoaHD(ma) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvChiTietBan.DataSource = ctbBUS.GetChiTietBan();
                    dgvDSHD.DataSource = dbBUS.GetDonHangBan();
                    cbMaDHB.DataSource = dbBUS.GetDonHangBan();
                    cbMaDHB.DisplayMember = "MaDHB";
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = string.Format("Convert(MaDHB, 'System.String') LIKE '%{0}%'", txtTimKiem.Text.Trim());
            (dgvDSHD.DataSource as DataTable).DefaultView.RowFilter = key;
            DataTable listDHB = new DataTable(); //Khởi tạo 
            listDHB = ctbBUS.TachMa(txtTimKiem.Text);
            dgvChiTietBan.DataSource = listDHB;

           
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDHB.Text = "";
            cbMaKH.Text = "";
            dtpNgayBan.Text = "";
            txtTongTien.Text = "";
            txtMaCT.Text = "";
            txtMaCT.Enabled = true;
            txtDvt.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
            txtMaDHB.Enabled = true;
            btnLamMoi.Enabled = true;
            btnThem.Enabled = true;
            btnThemCT.Enabled = true;
            dgvDSHD.DataSource = dbBUS.GetDonHangBan();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ma = txtMaDHB.Text;
            string nkh = cbMaKH.SelectedValue.ToString();
            DateTime nb = DateTime.Parse(dtpNgayBan.Value.ToShortDateString());
            float tongtien = float.Parse(txtTongTien.Text);
            DonHangBanDTO hdb = new DonHangBanDTO(ma, nkh, nb, tongtien);

            if (dbBUS.SuaHD(hdb) == true)
            {
                MessageBox.Show("Lưu thành công");
                dgvDSHD.DataSource = dbBUS.GetDonHangBan();
            }
        }

        private void dgvChiTietBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;

            txtMaCT.Text = dgvChiTietBan[0, hang].Value.ToString();
            cbMaSP.SelectedValue = dgvChiTietBan[2, hang].Value.ToString();
            cbMaDHB.Text = dgvChiTietBan[1, hang].Value.ToString();
            txtDvt.Text = dgvChiTietBan[3, hang].Value.ToString();
            txtSoLuong.Text = dgvChiTietBan[4, hang].Value.ToString();
            txtDonGia.Text = dgvChiTietBan[5, hang].Value.ToString();
            txtThanhTien.Text = dgvChiTietBan[6, hang].Value.ToString();
            txtMaCT.Enabled = true;
            btnThemCT.Enabled = false;
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaSP.SelectedValue != null)
            {
                string maSP = cbMaSP.SelectedValue.ToString();
                DataTable dt = spBUS.GetThongTinSanPham(maSP);
                if (dt.Rows.Count > 0)
                {
                    txtDvt.Text = dt.Rows[0]["DonViTinh"].ToString();
                    txtDonGia.Text = dt.Rows[0]["GiaBan"].ToString();
                }
            }
        }
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            string ma = txtMaCT.Text;
            string maSP = cbMaSP.SelectedValue.ToString();
            int maDHB = int.Parse(cbMaDHB.Text);
            string dvt = txtDvt.Text;
            int sol = int.Parse(txtSoLuong.Text);
            int dong = int.Parse(txtDonGia.Text);
            int thanht = sol * dong;
            txtThanhTien.Text = thanht.ToString();


            ChiTietDHBDTO ctb = new ChiTietDHBDTO(ma, maDHB, maSP, dvt, sol, dong, thanht);
            if (ctbBUS.KiemTraMaTrung(ma) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (dbBUS.ThemCTB(ctb) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvChiTietBan.DataSource = ctbBUS.GetChiTietBan();
                    DataTable listDHB = new DataTable(); //Khởi tạo 
                    listDHB = ctbBUS.GetSpByMaB(txtMaDHB.Text);
                    dgvChiTietBan.DataSource = listDHB;
                    int tong = 0;
                    for (int i = 0; i < dgvChiTietBan.Rows.Count; ++i)
                    {
                        tong += Convert.ToInt32(dgvChiTietBan.Rows[i].Cells[6].Value);

                    }
                    txtTongTien.Text = tong.ToString();
                    int rowIndex = dgvDSHD.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dgvDSHD.Rows[rowIndex];
                    string value = txtTongTien.Text;
                    selectedRow.Cells[3].Value = value;
                }
            }

        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            string ma = txtMaCT.Text;
            string maSP = cbMaSP.SelectedValue.ToString();
            int maDHB = int.Parse(cbMaDHB.Text);
            string dvt = txtDvt.Text;
            int SoLuong = int.Parse(txtSoLuong.Text);
            float dg = float.Parse(txtDonGia.Text);
            float ThanhTien = SoLuong * dg;
            txtThanhTien.Text = ThanhTien.ToString();

            ChiTietDHBDTO ctb = new ChiTietDHBDTO(ma, maDHB, maSP, dvt, SoLuong, dg, ThanhTien);
            if (dbBUS.SuaCTB(ctb) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgvChiTietBan.DataSource = ctbBUS.GetChiTietBan();
                DataTable listDHB = new DataTable(); //Khởi tạo
                listDHB = ctbBUS.GetSpByMaB(txtMaDHB.Text);
                dgvChiTietBan.DataSource = listDHB;
                int tong = 0;
                for (int i = 0; i < listDHB.Rows.Count; i++)
                {
                    tong += Convert.ToInt32(dgvChiTietBan.Rows[i].Cells[6].Value);
                }
                txtTongTien.Text = tong.ToString();
                int rowIndex = dgvDSHD.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgvDSHD.Rows[rowIndex];
                string value = txtTongTien.Text;
                selectedRow.Cells[3].Value = value;
                btnThemCT.Enabled = true;
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            string ma = txtMaCT.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (ctbBUS.XoaCTB(ma) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvChiTietBan.DataSource = ctbBUS.GetChiTietBan();
                    DataTable listDHB = new DataTable(); //Khởi tạo 
                    listDHB = ctbBUS.GetSpByMaB(txtMaDHB.Text);
                    dgvChiTietBan.DataSource = listDHB;
                    int tong = 0;
                    for (int i = 0; i < dgvChiTietBan.Rows.Count; ++i)
                    {
                        tong += Convert.ToInt32(dgvChiTietBan.Rows[i].Cells[6].Value);

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
            btnSuaCT.Enabled = true;
            btnXoaCT.Enabled = true;
        }

        private void dgvDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            FrmHoaDonBan frmInHoaDonBan = new FrmHoaDonBan();

            if (int.TryParse(txtMaDHB.Text.Trim(), out int maHDB)) // Chuyển đổi string sang int
            {
                frmInHoaDonBan.MaDHB = maHDB;
                frmInHoaDonBan.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mã hóa đơn nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
