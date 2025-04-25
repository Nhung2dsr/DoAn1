namespace GUI
{
    partial class FrmHoaDonBan
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
            this.HoaDonBanInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inHoaDonBan = new GUI.InHoaDonBan();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hoaDonBanInTableAdapter1 = new GUI.InHoaDonBanTableAdapters.HoaDonBanInTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBanInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonBan)).BeginInit();
            this.SuspendLayout();
            // 
            // HoaDonBanInBindingSource
            // 
            this.HoaDonBanInBindingSource.DataMember = "HoaDonBanIn";
            this.HoaDonBanInBindingSource.DataSource = this.inHoaDonBan;
            // 
            // inHoaDonBan
            // 
            this.inHoaDonBan.DataSetName = "InHoaDonBan";
            this.inHoaDonBan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "InHoaDonBan";
            reportDataSource1.Value = this.HoaDonBanInBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.RpHoaDonBan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1100, 658);
            this.reportViewer1.TabIndex = 0;
            // 
            // hoaDonBanInTableAdapter1
            // 
            this.hoaDonBanInTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 657);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmHoaDonBan";
            this.Text = "FrmHoaDonBan";
            this.Load += new System.EventHandler(this.FrmHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBanInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHoaDonBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDonBanInBindingSource;
        private InHoaDonBan inHoaDonBan;
        private InHoaDonBanTableAdapters.HoaDonBanInTableAdapter hoaDonBanInTableAdapter1;
    }
}