namespace GUI
{
    partial class FrmHoaDonNhap
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HoaDonNhapInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inHoaDonNhap = new GUI.InHoaDonNhap();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hoaDonNhapInTableAdapter = new GUI.InHoaDonNhapTableAdapters.HoaDonNhapInTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonNhapInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // HoaDonNhapInBindingSource
            // 
            this.HoaDonNhapInBindingSource.DataMember = "HoaDonNhapIn";
            this.HoaDonNhapInBindingSource.DataSource = this.inHoaDonNhap;
            // 
            // inHoaDonNhap
            // 
            this.inHoaDonNhap.DataSetName = "InHoaDonNhap";
            this.inHoaDonNhap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HoaDonNhap";
            reportDataSource1.Value = this.HoaDonNhapInBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.RpHoaDonNhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1252, 641);
            this.reportViewer1.TabIndex = 0;
            // 
            // hoaDonNhapInTableAdapter
            // 
            this.hoaDonNhapInTableAdapter.ClearBeforeFill = true;
            // 
            // FrmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 641);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHoaDonNhap";
            this.Text = "Hóa đơn nhập";
            this.Load += new System.EventHandler(this.FrmHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonNhapInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private InHoaDonNhap inHoaDonNhap;
        private InHoaDonNhapTableAdapters.HoaDonNhapInTableAdapter hoaDonNhapInTableAdapter;
        private System.Windows.Forms.BindingSource HoaDonNhapInBindingSource;
    }
}