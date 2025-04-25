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
    public partial class FrmQuenMK : Form
    {
        DangNhapBUS qlb = new DangNhapBUS(); ///Khai báo đối tượng cho lớp DangNhapBUS
        DangNhapDTO qdto = new DangNhapDTO();
        public FrmQuenMK()
        {
            InitializeComponent();
            lbKetQua.Text = "";
        }

        private void FrmQuenMK_Load(object sender, EventArgs e)
        {

        }

        private void FrmQuenMK_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            //Kiểm tra điều kiện của ô textbox Email
            if (email.Trim() == "") { MessageBox.Show("Vui long nhap Email đăng ký"); }
            else
            {
                //string q = "Select * from  TaiKhoan where Email = '" + email + "'";
                if (qlb.KiemTraEmai(txtEmail.Text) == 1)
                {
                    lbKetQua.ForeColor = Color.Blue;
                    lbKetQua.Text = "Mật Khẩu: 123";
                }


                else
                {
                    lbKetQua.ForeColor = Color.Red;
                    lbKetQua.Text = "Email này chưa được đăng kí!";
                }

            }
        }
    }
}
