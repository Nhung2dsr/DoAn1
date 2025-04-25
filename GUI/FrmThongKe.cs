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
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace GUI
{
    public partial class FrmThongKe : Form
    {
        DonHangBanBUS dhb = new DonHangBanBUS();
        DonHangNhapBUS dhn = new DonHangNhapBUS();
        SanPhamBUS hangHoa = new SanPhamBUS();
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtTong.Enabled = false;
            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i.ToString());
            }

        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgvThongKe.DataSource = dhb.GetDonHangBanTKeThang(cbThang.Text);

            //int tong = 0;
            //for (int i = 0; i < dgvThongKe.Rows.Count; ++i)
            //{
            //    tong += Convert.ToInt32(dgvThongKe.Rows[i].Cells[2].Value);

            //}
            //txtTong.Text = tong.ToString();
        }
        private void LoadDataGridView()
        {

            // Cấu hình DataGridView
            dgvThongKe.Columns[0].HeaderText = "Loại";
            dgvThongKe.Columns[1].HeaderText = "Tổng Tiền";
            dgvThongKe.AllowUserToAddRows = false;
            dgvThongKe.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        

        private void FrmThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void radDoanhThu_CheckedChanged(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = dhb.GetDonHangBanTKeThang(cbThang.Text);
            int tong = 0;
            for (int i = 0; i < dgvThongKe.Rows.Count; ++i)
            {
                tong += Convert.ToInt32(dgvThongKe.Rows[i].Cells[2].Value);

            }
            txtTong.Text = tong.ToString();
        }

        private void radChiPhi_CheckedChanged(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = dhn.GetDonHangNhapTKe(cbThang.Text);
            int tong = 0;
            for (int i = 0; i < dgvThongKe.Rows.Count; ++i)
            {
                tong += Convert.ToInt32(dgvThongKe.Rows[i].Cells[2].Value);

            }
            txtTong.Text = tong.ToString();
        }

        private void radLoiNhuan_CheckedChanged(object sender, EventArgs e)
        {

            dgvThongKe.DataSource = dhb.GetDonHangBanTKeThang(cbThang.Text);
            LoadDataGridView();
            int tongBan = 0;
            for (int i = 0; i < dgvThongKe.Rows.Count; ++i)
            {
                tongBan += Convert.ToInt32(dgvThongKe.Rows[i].Cells[2].Value);

            }
            dgvThongKe.DataSource = dhn.GetDonHangNhapTKe(cbThang.Text);
            LoadDataGridView();
            int tongNhap = 0;
            for (int i = 0; i < dgvThongKe.Rows.Count; ++i)
            {
                tongNhap += Convert.ToInt32(dgvThongKe.Rows[i].Cells[2].Value);

            }
            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("Phân Loại", typeof(string));
            dtResult.Columns.Add("Tổng Tiền", typeof(int));

            // Thêm dữ liệu tổng chi phí và tổng doanh thu vào DataTable
            dtResult.Rows.Add("Tổng Doanh Thu", tongBan);
            dtResult.Rows.Add("Tổng Chi Phí Nhập", tongNhap);

            // Gán DataTable mới làm DataSource cho DataGridView
            dgvThongKe.DataSource = dtResult;

            int LoiNhuan = tongBan - tongNhap;
            txtTong.Text = LoiNhuan.ToString();
        }
    }
}
