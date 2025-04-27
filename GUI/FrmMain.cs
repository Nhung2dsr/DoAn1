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
    public partial class FrmMain : Form
    {
        private int childFormNumber = 0;
        public FrmMain()
        {         
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }


        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rt = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rt == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoaiSanPham frmLoaiHang = new FrmLoaiSanPham();
            this.Hide();
            frmLoaiHang.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhaCC frmNhaCC = new FrmNhaCC();
            this.Hide();
            frmNhaCC.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhachHang frmKhachHang = new FrmKhachHang();
            this.Hide();
            frmKhachHang.ShowDialog();
            this.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSanPham = new FrmSanPham();
            this.Hide();
            frmSanPham.ShowDialog();
            this.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void đơnHàngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDonHangNhap frmDonHangNhap = new FrmDonHangNhap();
            this.Hide();
            frmDonHangNhap.ShowDialog();
            this.Show();
        }

        private void đơnHàngBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDonHangBan frmDonHangBan = new FrmDonHangBan();
            this.Hide();
            frmDonHangBan.ShowDialog();
            this.Show();
        }

        private void thốngKêBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongKe frmThongKe = new FrmThongKe();
            this.Hide();
            frmThongKe.ShowDialog();
            this.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau frmDoiMatKhau = new FrmDoiMatKhau();
            this.Hide();
            frmDoiMatKhau.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap dangnhap = new FrmDangNhap();
            if (dangnhap.ShowDialog() == DialogResult.OK)
            {
                // Nếu đăng nhập lại thành công, thì mở lại form Main
                this.Show();
            }
            else
            {
                // Nếu thoát khỏi form đăng nhập, thì đóng luôn chương trình
                this.Close();
            }
        }
    }
}
