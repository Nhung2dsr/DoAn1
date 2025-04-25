namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHangBan")]
    public partial class DonHangBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHangBan()
        {
            ChiTietDHBs = new HashSet<ChiTietDHB>();
        }

        [Key]
        [StringLength(10)]
        public string MaDHB { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        public DateTime? NgayBan { get; set; }

        public double? TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDHB> ChiTietDHBs { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
