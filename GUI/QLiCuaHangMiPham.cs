using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GUI
{
    public partial class QLiCuaHangMiPham : DbContext
    {
        public QLiCuaHangMiPham()
            : base("name=HDN")
        {
        }

        public virtual DbSet<ChiTietDHB> ChiTietDHBs { get; set; }
        public virtual DbSet<ChiTietDHN> ChiTietDHNs { get; set; }
        public virtual DbSet<DonHangBan> DonHangBans { get; set; }
        public virtual DbSet<DonHangNhap> DonHangNhaps { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiHang> LoaiHangs { get; set; }
        public virtual DbSet<MatHang> MatHangs { get; set; }
        public virtual DbSet<NhaCC> NhaCCs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonHangBan>()
                .HasMany(e => e.ChiTietDHBs)
                .WithOptional(e => e.DonHangBan)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DonHangNhap>()
                .HasMany(e => e.ChiTietDHNs)
                .WithOptional(e => e.DonHangNhap)
                .WillCascadeOnDelete();

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.DonHangBans)
                .WithOptional(e => e.KhachHang)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LoaiHang>()
                .HasMany(e => e.MatHangs)
                .WithOptional(e => e.LoaiHang)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhaCC>()
                .HasMany(e => e.DonHangNhaps)
                .WithOptional(e => e.NhaCC)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhaCC>()
                .HasMany(e => e.MatHangs)
                .WithOptional(e => e.NhaCC)
                .WillCascadeOnDelete();
        }
    }
}
