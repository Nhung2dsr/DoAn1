namespace GUI
{
    partial class FrmDonHangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbMaNCC = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaDHN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.btnInHoaDonNhap = new System.Windows.Forms.Button();
            this.btnLamMoiCT = new System.Windows.Forms.Button();
            this.btnXoaCTN = new System.Windows.Forms.Button();
            this.btnSuaCTN = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.dgvChiTietNhap = new System.Windows.Forms.DataGridView();
            this.cbMaHDN = new System.Windows.Forms.ComboBox();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDvt = new System.Windows.Forms.TextBox();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.grbThongTinHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.grbChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOÁ ĐƠN NHẬP HÀNG";
            // 
            // grbThongTinHoaDon
            // 
            this.grbThongTinHoaDon.Controls.Add(this.txtTimKiem);
            this.grbThongTinHoaDon.Controls.Add(this.label13);
            this.grbThongTinHoaDon.Controls.Add(this.btnLuu);
            this.grbThongTinHoaDon.Controls.Add(this.btnLamMoi);
            this.grbThongTinHoaDon.Controls.Add(this.btnTimKiem);
            this.grbThongTinHoaDon.Controls.Add(this.btnXoa);
            this.grbThongTinHoaDon.Controls.Add(this.btnSua);
            this.grbThongTinHoaDon.Controls.Add(this.btnThem);
            this.grbThongTinHoaDon.Controls.Add(this.dgvDSHD);
            this.grbThongTinHoaDon.Controls.Add(this.dtpNgayNhap);
            this.grbThongTinHoaDon.Controls.Add(this.cbMaNCC);
            this.grbThongTinHoaDon.Controls.Add(this.txtTongTien);
            this.grbThongTinHoaDon.Controls.Add(this.txtMaDHN);
            this.grbThongTinHoaDon.Controls.Add(this.label5);
            this.grbThongTinHoaDon.Controls.Add(this.label4);
            this.grbThongTinHoaDon.Controls.Add(this.label3);
            this.grbThongTinHoaDon.Controls.Add(this.label2);
            this.grbThongTinHoaDon.Location = new System.Drawing.Point(12, 81);
            this.grbThongTinHoaDon.Name = "grbThongTinHoaDon";
            this.grbThongTinHoaDon.Size = new System.Drawing.Size(537, 651);
            this.grbThongTinHoaDon.TabIndex = 1;
            this.grbThongTinHoaDon.TabStop = false;
            this.grbThongTinHoaDon.Text = "Thông tin hóa đơn";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(123, 499);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(285, 34);
            this.txtTimKiem.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 507);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 26);
            this.label13.TabIndex = 15;
            this.label13.Text = "Tìm kiếm";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(300, 599);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(117, 30);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(106, 599);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(117, 30);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(414, 505);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(117, 30);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(388, 553);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 30);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(208, 553);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 30);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(34, 553);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 30);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Location = new System.Drawing.Point(0, 249);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.RowHeadersWidth = 51;
            this.dgvDSHD.RowTemplate.Height = 24;
            this.dgvDSHD.Size = new System.Drawing.Size(537, 239);
            this.dgvDSHD.TabIndex = 8;
            this.dgvDSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellClick);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(219, 144);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(300, 34);
            this.dtpNgayNhap.TabIndex = 7;
            this.dtpNgayNhap.Value = new System.DateTime(2024, 10, 22, 20, 10, 46, 0);
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.Location = new System.Drawing.Point(219, 95);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(300, 34);
            this.cbMaNCC.TabIndex = 6;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(219, 190);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(300, 34);
            this.txtTongTien.TabIndex = 5;
            // 
            // txtMaDHN
            // 
            this.txtMaDHN.Location = new System.Drawing.Point(219, 49);
            this.txtMaDHN.Name = "txtMaDHN";
            this.txtMaDHN.ReadOnly = true;
            this.txtMaDHN.Size = new System.Drawing.Size(300, 34);
            this.txtMaDHN.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn nhập";
            // 
            // grbChiTietHoaDon
            // 
            this.grbChiTietHoaDon.Controls.Add(this.btnInHoaDonNhap);
            this.grbChiTietHoaDon.Controls.Add(this.btnLamMoiCT);
            this.grbChiTietHoaDon.Controls.Add(this.btnXoaCTN);
            this.grbChiTietHoaDon.Controls.Add(this.btnSuaCTN);
            this.grbChiTietHoaDon.Controls.Add(this.btnThemCT);
            this.grbChiTietHoaDon.Controls.Add(this.dgvChiTietNhap);
            this.grbChiTietHoaDon.Controls.Add(this.cbMaHDN);
            this.grbChiTietHoaDon.Controls.Add(this.cbMaSP);
            this.grbChiTietHoaDon.Controls.Add(this.txtThanhTien);
            this.grbChiTietHoaDon.Controls.Add(this.txtDonGia);
            this.grbChiTietHoaDon.Controls.Add(this.txtSoLuong);
            this.grbChiTietHoaDon.Controls.Add(this.txtDvt);
            this.grbChiTietHoaDon.Controls.Add(this.txtMaCT);
            this.grbChiTietHoaDon.Controls.Add(this.label12);
            this.grbChiTietHoaDon.Controls.Add(this.label11);
            this.grbChiTietHoaDon.Controls.Add(this.label10);
            this.grbChiTietHoaDon.Controls.Add(this.label9);
            this.grbChiTietHoaDon.Controls.Add(this.label8);
            this.grbChiTietHoaDon.Controls.Add(this.label7);
            this.grbChiTietHoaDon.Controls.Add(this.label6);
            this.grbChiTietHoaDon.Location = new System.Drawing.Point(555, 81);
            this.grbChiTietHoaDon.Name = "grbChiTietHoaDon";
            this.grbChiTietHoaDon.Size = new System.Drawing.Size(733, 651);
            this.grbChiTietHoaDon.TabIndex = 2;
            this.grbChiTietHoaDon.TabStop = false;
            this.grbChiTietHoaDon.Text = "Chi tiết hóa đơn";
            // 
            // btnInHoaDonNhap
            // 
            this.btnInHoaDonNhap.Location = new System.Drawing.Point(293, 599);
            this.btnInHoaDonNhap.Name = "btnInHoaDonNhap";
            this.btnInHoaDonNhap.Size = new System.Drawing.Size(170, 39);
            this.btnInHoaDonNhap.TabIndex = 19;
            this.btnInHoaDonNhap.Text = "In hóa đơn";
            this.btnInHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnInHoaDonNhap.Click += new System.EventHandler(this.btnInHoaDonNhap_Click_1);
            // 
            // btnLamMoiCT
            // 
            this.btnLamMoiCT.Location = new System.Drawing.Point(588, 528);
            this.btnLamMoiCT.Name = "btnLamMoiCT";
            this.btnLamMoiCT.Size = new System.Drawing.Size(105, 30);
            this.btnLamMoiCT.TabIndex = 18;
            this.btnLamMoiCT.Text = "Làm mới";
            this.btnLamMoiCT.UseVisualStyleBackColor = true;
            this.btnLamMoiCT.Click += new System.EventHandler(this.btnLamMoiCT_Click);
            // 
            // btnXoaCTN
            // 
            this.btnXoaCTN.Location = new System.Drawing.Point(409, 528);
            this.btnXoaCTN.Name = "btnXoaCTN";
            this.btnXoaCTN.Size = new System.Drawing.Size(105, 30);
            this.btnXoaCTN.TabIndex = 17;
            this.btnXoaCTN.Text = "Xóa";
            this.btnXoaCTN.UseVisualStyleBackColor = true;
            this.btnXoaCTN.Click += new System.EventHandler(this.btnXoaCTN_Click);
            // 
            // btnSuaCTN
            // 
            this.btnSuaCTN.Location = new System.Drawing.Point(225, 528);
            this.btnSuaCTN.Name = "btnSuaCTN";
            this.btnSuaCTN.Size = new System.Drawing.Size(105, 30);
            this.btnSuaCTN.TabIndex = 16;
            this.btnSuaCTN.Text = "Sửa";
            this.btnSuaCTN.UseVisualStyleBackColor = true;
            this.btnSuaCTN.Click += new System.EventHandler(this.btnSuaCTN_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Location = new System.Drawing.Point(46, 528);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(105, 30);
            this.btnThemCT.TabIndex = 15;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // dgvChiTietNhap
            // 
            this.dgvChiTietNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNhap.Location = new System.Drawing.Point(0, 249);
            this.dgvChiTietNhap.Name = "dgvChiTietNhap";
            this.dgvChiTietNhap.RowHeadersWidth = 51;
            this.dgvChiTietNhap.RowTemplate.Height = 24;
            this.dgvChiTietNhap.Size = new System.Drawing.Size(733, 239);
            this.dgvChiTietNhap.TabIndex = 14;
            this.dgvChiTietNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietNhap_CellClick);
            // 
            // cbMaHDN
            // 
            this.cbMaHDN.FormattingEnabled = true;
            this.cbMaHDN.Location = new System.Drawing.Point(199, 142);
            this.cbMaHDN.Name = "cbMaHDN";
            this.cbMaHDN.Size = new System.Drawing.Size(160, 34);
            this.cbMaHDN.TabIndex = 13;
            // 
            // cbMaSP
            // 
            this.cbMaSP.FormattingEnabled = true;
            this.cbMaSP.Location = new System.Drawing.Point(199, 95);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(160, 34);
            this.cbMaSP.TabIndex = 12;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(513, 150);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(194, 34);
            this.txtThanhTien.TabIndex = 11;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(512, 104);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(194, 34);
            this.txtDonGia.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(512, 57);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(194, 34);
            this.txtSoLuong.TabIndex = 9;
            // 
            // txtDvt
            // 
            this.txtDvt.Location = new System.Drawing.Point(199, 190);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(160, 34);
            this.txtDvt.TabIndex = 8;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Enabled = false;
            this.txtMaCT.Location = new System.Drawing.Point(199, 54);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(160, 34);
            this.txtMaCT.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(395, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 26);
            this.label12.TabIndex = 6;
            this.label12.Text = "Thành tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(395, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 26);
            this.label11.TabIndex = 5;
            this.label11.Text = "Đơn giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 26);
            this.label9.TabIndex = 3;
            this.label9.Text = "Đơn vị tính";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã hóa đơn nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã chi tiết";
            // 
            // FrmDonHangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1300, 731);
            this.Controls.Add(this.grbChiTietHoaDon);
            this.Controls.Add(this.grbThongTinHoaDon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDonHangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDonHangNhap_FormClosing);
            this.Load += new System.EventHandler(this.FrmDonHangNhap_Load);
            this.grbThongTinHoaDon.ResumeLayout(false);
            this.grbThongTinHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.grbChiTietHoaDon.ResumeLayout(false);
            this.grbChiTietHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTinHoaDon;
        private System.Windows.Forms.GroupBox grbChiTietHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.ComboBox cbMaNCC;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaDHN;
        private System.Windows.Forms.ComboBox cbMaHDN;
        private System.Windows.Forms.ComboBox cbMaSP;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.DataGridView dgvChiTietNhap;
        private System.Windows.Forms.Button btnInHoaDonNhap;
        private System.Windows.Forms.Button btnLamMoiCT;
        private System.Windows.Forms.Button btnXoaCTN;
        private System.Windows.Forms.Button btnSuaCTN;
        private System.Windows.Forms.Button btnThemCT;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}