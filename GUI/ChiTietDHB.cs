namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDHB")]
    public partial class ChiTietDHB
    {
        [Key]
        [StringLength(10)]
        public string MaCTB { get; set; }

        [StringLength(10)]
        public string MaDHB { get; set; }

        [StringLength(10)]
        public string MaMH { get; set; }

        [StringLength(10)]
        public string DvTinh { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public double? ThanhTien { get; set; }

        public virtual DonHangBan DonHangBan { get; set; }

        public virtual MatHang MatHang { get; set; }
    }
}
