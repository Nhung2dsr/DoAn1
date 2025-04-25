namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDHN")]
    public partial class ChiTietDHN
    {
        [Key]
        [StringLength(10)]
        public string MaCTN { get; set; }

        [StringLength(10)]
        public string MaDHN { get; set; }

        [StringLength(10)]
        public string MaMH { get; set; }

        [StringLength(10)]
        public string DvTinh { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public double? ThanhTien { get; set; }

        public virtual DonHangNhap DonHangNhap { get; set; }

        public virtual MatHang MatHang { get; set; }
    }
}
