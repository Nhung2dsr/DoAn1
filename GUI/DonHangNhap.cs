namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHangNhap")]
    public partial class DonHangNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHangNhap()
        {
            ChiTietDHNs = new HashSet<ChiTietDHN>();
        }

        [Key]
        [StringLength(10)]
        public string MaDHN { get; set; }

        [StringLength(10)]
        public string MaNCC { get; set; }

        public DateTime? NgayNhap { get; set; }

        public double? TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDHN> ChiTietDHNs { get; set; }

        public virtual NhaCC NhaCC { get; set; }
    }
}
