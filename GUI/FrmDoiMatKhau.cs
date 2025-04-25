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
    public partial class FrmDoiMatKhau : Form
    {
        DangNhapBUS busdn = new DangNhapBUS();
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string mkc = txtMatKCu.Text;
            string mkm = txtMKMoi.Text;
            string nl = txtNhapLaiMK.Text;
            DangNhapDTO dn = new DangNhapDTO(mkm, email);//Khai báo đối tượng DangNhapDTO
            //Kiểm tra các điều kiện của các ô textbox
            if (busdn.KiemTraEmaiMatKhau(email, mkc) == 0)
            {
                MessageBox.Show("Email hoặc mật khẩu cũ không đúng");
            }
            else
            {
                if (mkm != nl)
                {
                    MessageBox.Show("Vui lòng nhập khớp mật khẩu mới");
                }
                else
                {
                    if (busdn.suaMK(dn) == true)
                    {
                        MessageBox.Show("Tạo thành công");
                        this.Hide();
                        FrmDangNhap home = new FrmDangNhap();
                        home.ShowDialog();
                        this.Close();
                    }
                }

            }
        }

        private void FrmDoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rt = MessageBox.Show("Bạn có muốn thoát không!!", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rt == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
