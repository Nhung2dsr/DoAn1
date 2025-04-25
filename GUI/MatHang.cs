namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatHang")]
    public partial class MatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatHang()
        {
            ChiTietDHBs = new HashSet<ChiTietDHB>();
            ChiTietDHNs = new HashSet<ChiTietDHN>();
        }

        [Key]
        [StringLength(10)]
        public string MaMH { get; set; }

        [StringLength(50)]
        public string TenMH { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(10)]
        public string DonViTinh { get; set; }

        [StringLength(10)]
        public string MaLH { get; set; }

        [StringLength(10)]
        public string MaNCC { get; set; }

        public DateTime? NSX { get; set; }

        public DateTime? HSD { get; set; }

        [StringLength(30)]
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDHB> ChiTietDHBs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDHN> ChiTietDHNs { get; set; }

        public virtual LoaiHang LoaiHang { get; set; }

        public virtual NhaCC NhaCC { get; set; }
    }
}
