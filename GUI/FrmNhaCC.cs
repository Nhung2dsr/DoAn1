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
using System.Web;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace GUI
{
    public partial class FrmNhaCC : Form
    {
        NhaCCBUS ccBUS = new NhaCCBUS();
        public FrmNhaCC()
        {
            InitializeComponent();
        }
        private void FrmNhaCC_Load(object sender, EventArgs e)
        {
            dgvNhaCC.DataSource = ccBUS.GetNhaCC();
            dgvNhaCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaNCC.Text = dgvNhaCC[0, hang].Value.ToString();
            txtTenNCC.Text = dgvNhaCC[1, hang].Value.ToString();
            txtDCNhaCC.Text = dgvNhaCC[2, hang].Value.ToString();
            txtEmailNCC.Text = dgvNhaCC[3, hang].Value.ToString();
            txtSoDTNhaCC.Text = dgvNhaCC[4, hang].Value.ToString();
            txtMaNCC.Enabled = false;
            btnThem.Enabled = false;
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        private bool IsValidPhoneNumber(string phone)
        {
            return phone.All(char.IsDigit) && phone.Length == 10;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                string ma = txtMaNCC.Text;
                string ten = txtTenNCC.Text;
                string DiaChi = txtDCNhaCC.Text;
                string Email = txtEmailNCC.Text;
                string SDT = txtSoDTNhaCC.Text;
                // Kiểm tra nếu bất kỳ ô nào trống
                if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(DiaChi)
                    || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(SDT))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Kiểm tra email
                if (!IsValidEmail(Email))
                {
                    MessageBox.Show("Email không đúng định dạng!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Kiểm tra số điện thoại
                if (!IsValidPhoneNumber(SDT))
                {
                    MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                NhaCCDTO nhaCC = new NhaCCDTO(ma, ten, DiaChi, Email, SDT);
                if (ccBUS.KiemTraMaTrung(ma) == 1)
                {
                    MessageBox.Show("Mã trùng");
                }
                else
                {
                    if (ccBUS.ThemNCC(nhaCC) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvNhaCC.DataSource = ccBUS.GetNhaCC();
                        txtMaNCC.Text = "";
                        txtTenNCC.Text = "";
                        txtDCNhaCC.Text = "";
                        txtSoDTNhaCC.Text = "";
                        txtEmailNCC.Text = "";
                        txtSoDTNhaCC.Text = "";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text;
            string ten = txtTenNCC.Text;
            string diachi = txtDCNhaCC.Text;
            string email = txtEmailNCC.Text;
            string sodt = txtSoDTNhaCC.Text;
            NhaCCDTO nhacc = new NhaCCDTO(ma,ten,diachi,email,sodt);

            if (ccBUS.SuaNCC(nhacc) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgvNhaCC.DataSource = ccBUS.GetNhaCC();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (ccBUS.XoaNCC(ma) == true) 
                {
                    MessageBox.Show("Xóa thành công");
                    dgvNhaCC.DataSource = ccBUS.GetNhaCC();
                }                    
            }                
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = string.Format("{0} like '{1}'", "TenNCC", "*" + txtTimKiemNCC.Text + "*");
            (dgvNhaCC.DataSource as DataTable).DefaultView.RowFilter = key;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDCNhaCC.Text = "";
            txtEmailNCC.Text = "";
            txtSoDTNhaCC.Text = "";
            btnThem.Enabled = true;
            txtMaNCC.Enabled = true;
            btnLamMoi.Enabled = true;
            dgvNhaCC.DataSource = ccBUS.GetNhaCC();

        }

        private void FrmNhaCC_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rt = MessageBox.Show("Bạn chắc chắn muốn thoát không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rt == DialogResult.Yes)
            {
                e.Cancel = false;
            } 
            else 
                e.Cancel= true;
        }

        
    }
}
