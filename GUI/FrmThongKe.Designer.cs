namespace GUI
{
    partial class FrmThongKe
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.radDoanhThu = new System.Windows.Forms.RadioButton();
            this.radChiPhi = new System.Windows.Forms.RadioButton();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.radLoiNhuan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(244, 101);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(471, 34);
            this.cbThang.TabIndex = 2;
            this.cbThang.SelectedIndexChanged += new System.EventHandler(this.cbThang_SelectedIndexChanged);
            // 
            // radDoanhThu
            // 
            this.radDoanhThu.AutoSize = true;
            this.radDoanhThu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDoanhThu.Location = new System.Drawing.Point(970, 255);
            this.radDoanhThu.Name = "radDoanhThu";
            this.radDoanhThu.Size = new System.Drawing.Size(140, 29);
            this.radDoanhThu.TabIndex = 3;
            this.radDoanhThu.TabStop = true;
            this.radDoanhThu.Text = "Doanh thu";
            this.radDoanhThu.UseVisualStyleBackColor = true;
            this.radDoanhThu.CheckedChanged += new System.EventHandler(this.radDoanhThu_CheckedChanged);
            // 
            // radChiPhi
            // 
            this.radChiPhi.AutoSize = true;
            this.radChiPhi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChiPhi.Location = new System.Drawing.Point(970, 372);
            this.radChiPhi.Name = "radChiPhi";
            this.radChiPhi.Size = new System.Drawing.Size(169, 29);
            this.radChiPhi.TabIndex = 5;
            this.radChiPhi.TabStop = true;
            this.radChiPhi.Text = "Chi phí nhập ";
            this.radChiPhi.UseVisualStyleBackColor = true;
            this.radChiPhi.CheckedChanged += new System.EventHandler(this.radChiPhi_CheckedChanged);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(49, 193);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(820, 396);
            this.dgvThongKe.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(244, 641);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(471, 34);
            this.txtTong.TabIndex = 8;
            // 
            // radLoiNhuan
            // 
            this.radLoiNhuan.AutoSize = true;
            this.radLoiNhuan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLoiNhuan.Location = new System.Drawing.Point(970, 488);
            this.radLoiNhuan.Name = "radLoiNhuan";
            this.radLoiNhuan.Size = new System.Drawing.Size(136, 29);
            this.radLoiNhuan.TabIndex = 9;
            this.radLoiNhuan.TabStop = true;
            this.radLoiNhuan.Text = "Lợi nhuận";
            this.radLoiNhuan.UseVisualStyleBackColor = true;
            this.radLoiNhuan.CheckedChanged += new System.EventHandler(this.radLoiNhuan_CheckedChanged);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1300, 731);
            this.Controls.Add(this.radLoiNhuan);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.radChiPhi);
            this.Controls.Add(this.radDoanhThu);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmThongKe_FormClosing);
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.RadioButton radDoanhThu;
        private System.Windows.Forms.RadioButton radChiPhi;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.RadioButton radLoiNhuan;
    }
}