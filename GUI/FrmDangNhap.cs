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
using BUS;

namespace GUI
{
    public partial class FrmDangNhap : Form
    {
        DangNhapBUS busdn = new DangNhapBUS();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void FrmDangNhap_Click(object sender, EventArgs e)
        {
          
        }


        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Chỉ hỏi người dùng khi họ chưa đăng nhập thành công
            if (this.DialogResult != DialogResult.OK)
            {
                DialogResult rt = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rt == DialogResult.No)
                {
                    e.Cancel = true; // Hủy đóng form
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhapDTO tk = new DangNhapDTO(); // tạo đối tượng DangNHapDTO mới
            string tentk = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            /// Kiểm tra các trường hợp của các ô textbox Tài Khaonr và Mật Khẩu
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else if (busdn.KiemTraTaiKhoan(tentk, matkhau) == 1)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công", "Thông báo");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên tài khoản/Mật khẩu không đúng.", "Thông báo");
                this.txtTaiKhoan.Focus();
            }
        }

        private void lblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmQuenMK quenmk = new FrmQuenMK();
            quenmk.ShowDialog();
            this.Close();
        }

        private void lblTaoMKMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDoiMatKhau frmDoiMatKhau = new FrmDoiMatKhau();
            frmDoiMatKhau .ShowDialog();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
