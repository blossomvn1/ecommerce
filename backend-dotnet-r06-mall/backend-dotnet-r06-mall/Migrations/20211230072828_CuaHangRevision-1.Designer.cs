﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend_dotnet_r06_mall.Data;

namespace backend_dotnet_r06_mall.Migrations
{
    [DbContext(typeof(BanHangContext))]
    [Migration("20211230072828_CuaHangRevision-1")]
    partial class CuaHangRevision1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.CuaHang", b =>
                {
                    b.Property<Guid>("CuaHangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DanhGia")
                        .HasMaxLength(2147483645)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(2147483645)
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("KinhDo")
                        .HasColumnType("float");

                    b.Property<string>("MaSoThue")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(2147483645)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STK")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TenCuaHang")
                        .IsRequired()
                        .HasMaxLength(2147483645)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.Property<double>("ViDo")
                        .HasColumnType("float");

                    b.HasKey("CuaHangId");

                    b.ToTable("CuaHang");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.DonHang", b =>
                {
                    b.Property<Guid>("DonHangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DanhGia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HinhThucThanhToanHinhThucId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("KhachHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("NguoiGiaoHangNguoiGiaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SoLuong")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TinhTrangThanhToan")
                        .HasColumnType("bit");

                    b.HasKey("DonHangId");

                    b.HasIndex("HinhThucThanhToanHinhThucId");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("NguoiGiaoHangNguoiGiaoId");

                    b.ToTable("DonHang");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.DonHangSanPham", b =>
                {
                    b.Property<Guid>("DonHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SanPhamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("DonHangId", "SanPhamId");

                    b.HasIndex("SanPhamId");

                    b.ToTable("DonHangSanPham");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.HinhThucThanhToan", b =>
                {
                    b.Property<Guid>("HinhThucId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenHTTT")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("HinhThucId");

                    b.ToTable("HinhThucThanhToan");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.KetQuaKiemTra", b =>
                {
                    b.Property<Guid>("KetQuaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KetQua")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("NgayKiemTra")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("NguoiGiaoHangNguoiGiaoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("KetQuaId");

                    b.HasIndex("NguoiGiaoHangNguoiGiaoId");

                    b.ToTable("KetQuaKiemTra");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.KhachHang", b =>
                {
                    b.Property<Guid>("KhachHangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cccd")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STK")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Vung")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("KhachHangId");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.LoaiSanPham", b =>
                {
                    b.Property<Guid>("LoaiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LoaiId");

                    b.ToTable("LoaiSanPham");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.NguoiGiaoHang", b =>
                {
                    b.Property<Guid>("NguoiGiaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cccd")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDangKy")
                        .HasColumnType("datetime2");

                    b.Property<string>("STK")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenNguoiGiaoHang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VungHoatDong")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("NguoiGiaoId");

                    b.ToTable("NguoiGiaoHang");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.SanPham", b =>
                {
                    b.Property<Guid>("SanPhamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CuaHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<int>("DonVi")
                        .HasColumnType("int");

                    b.Property<Guid?>("LoaiSanPhamLoaiId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasMaxLength(2147483645)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDang")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasMaxLength(2147483645)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TonKho")
                        .HasColumnType("int");

                    b.HasKey("SanPhamId");

                    b.HasIndex("CuaHangId");

                    b.HasIndex("LoaiSanPhamLoaiId");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.ThongTinDiDuong", b =>
                {
                    b.Property<Guid>("TTTDId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayCap")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("NguoiGiaoHangNguoiGiaoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TTTDId");

                    b.HasIndex("NguoiGiaoHangNguoiGiaoId");

                    b.ToTable("ThongTinDiDuong");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.TinhTrangDonHang", b =>
                {
                    b.Property<Guid>("TTDHId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DonHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayThucHien")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenTinhTrang")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("TTDHId");

                    b.HasIndex("DonHangId");

                    b.ToTable("TinhTrangDonHang");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.DonHang", b =>
                {
                    b.HasOne("backend_dotnet_r06_mall.Models.HinhThucThanhToan", "HinhThucThanhToan")
                        .WithMany()
                        .HasForeignKey("HinhThucThanhToanHinhThucId");

                    b.HasOne("backend_dotnet_r06_mall.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("KhachHangId");

                    b.HasOne("backend_dotnet_r06_mall.Models.NguoiGiaoHang", "NguoiGiaoHang")
                        .WithMany("DonHang")
                        .HasForeignKey("NguoiGiaoHangNguoiGiaoId");

                    b.Navigation("HinhThucThanhToan");

                    b.Navigation("KhachHang");

                    b.Navigation("NguoiGiaoHang");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.DonHangSanPham", b =>
                {
                    b.HasOne("backend_dotnet_r06_mall.Models.DonHang", "DonHang")
                        .WithMany("DonHangSanPham")
                        .HasForeignKey("DonHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend_dotnet_r06_mall.Models.SanPham", "SanPham")
                        .WithMany("DonHangSanPham")
                        .HasForeignKey("SanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonHang");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.KetQuaKiemTra", b =>
                {
                    b.HasOne("backend_dotnet_r06_mall.Models.NguoiGiaoHang", null)
                        .WithMany("KetQuaKiemTra")
                        .HasForeignKey("NguoiGiaoHangNguoiGiaoId");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.SanPham", b =>
                {
                    b.HasOne("backend_dotnet_r06_mall.Models.CuaHang", "CuaHang")
                        .WithMany()
                        .HasForeignKey("CuaHangId");

                    b.HasOne("backend_dotnet_r06_mall.Models.LoaiSanPham", "LoaiSanPham")
                        .WithMany()
                        .HasForeignKey("LoaiSanPhamLoaiId");

                    b.Navigation("CuaHang");

                    b.Navigation("LoaiSanPham");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.ThongTinDiDuong", b =>
                {
                    b.HasOne("backend_dotnet_r06_mall.Models.NguoiGiaoHang", null)
                        .WithMany("ThongTinDiDuong")
                        .HasForeignKey("NguoiGiaoHangNguoiGiaoId");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.TinhTrangDonHang", b =>
                {
                    b.HasOne("backend_dotnet_r06_mall.Models.DonHang", "DonHang")
                        .WithMany("TinhTrangDonHang")
                        .HasForeignKey("DonHangId");

                    b.Navigation("DonHang");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.DonHang", b =>
                {
                    b.Navigation("DonHangSanPham");

                    b.Navigation("TinhTrangDonHang");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.NguoiGiaoHang", b =>
                {
                    b.Navigation("DonHang");

                    b.Navigation("KetQuaKiemTra");

                    b.Navigation("ThongTinDiDuong");
                });

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.SanPham", b =>
                {
                    b.Navigation("DonHangSanPham");
                });
#pragma warning restore 612, 618
        }
    }
}
