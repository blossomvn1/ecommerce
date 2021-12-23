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
    [Migration("20211221124841_ModelRevisions-2")]
    partial class ModelRevisions2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.CuaHang", b =>
                {
                    b.Property<Guid>("CuaHangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DanhGia")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("STK")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenCuaHang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("TinhTrangDonHangTTDHId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("TinhTrangThanhToan")
                        .HasColumnType("bit");

                    b.HasKey("DonHangId");

                    b.HasIndex("HinhThucThanhToanHinhThucId");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("NguoiGiaoHangNguoiGiaoId");

                    b.HasIndex("TinhTrangDonHangTTDHId");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSanPham")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.Property<string>("TenTinhTrang")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("TTDHId");

                    b.ToTable("TinhTrangDonHang");
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

                    b.HasOne("backend_dotnet_r06_mall.Models.TinhTrangDonHang", "TinhTrangDonHang")
                        .WithMany()
                        .HasForeignKey("TinhTrangDonHangTTDHId");

                    b.Navigation("HinhThucThanhToan");

                    b.Navigation("KhachHang");

                    b.Navigation("NguoiGiaoHang");

                    b.Navigation("TinhTrangDonHang");
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

            modelBuilder.Entity("backend_dotnet_r06_mall.Models.DonHang", b =>
                {
                    b.Navigation("DonHangSanPham");
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