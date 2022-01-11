using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_dotnet_r06_mall.Data;
using backend_dotnet_r06_mall.Models;
using backend_dotnet_r06_mall.Requests;
using backend_dotnet_r06_mall.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_dotnet_r06_mall.Services
{
    public class CartServices
    {
        private readonly BanHangContext _context;


        public CartServices(BanHangContext context)
        {
            _context = context;
        }

        public async Task<bool> TaoDonHang(CartRequest gh, Guid userId)
        {
            DonHang dh = new DonHang
            {
                DonHangId = new Guid(),
                ThoiGian = DateTime.UtcNow,
                TinhTrangThanhToan = false,
                KhachHang = await _context.KhachHang.FirstOrDefaultAsync(o => o.KhachHangId == userId),
                SoLuong = 1
            };

            dh.DonHangSanPham = new List<DonHangSanPham>();

            foreach (var item in gh.listsp)
            {
                DonHangSanPham dhsp = new DonHangSanPham
                {
                    DonHang = dh,
                    SanPham = await _context.SanPham.FirstOrDefaultAsync(o => o.SanPhamId == item.idsp),
                    SoLuong = item.sl

                };
                dh.DonHangSanPham.Add(dhsp);
            }

            var createResult = await _context.DonHang.AddAsync(dh);
            await _context.SaveChangesAsync();
            return createResult is not null;
        }
        public async Task<IList<DonHangSanPham>> loadDonHang(Guid donHangId)
        {
            //tra ve gio hang theo ma don hang trong bang DonHangSanPham
            var s = await _context.DonHang.Include(q => q.DonHangSanPham).FirstOrDefaultAsync(q => q.DonHangId == donHangId);
            return s.DonHangSanPham;
        }
        //update tinh trang don hang = da thanh toan
        public async Task<bool> thanhToan(Guid donHangId, Guid userId)
        {
            var donHang = await _context.DonHang.Include(o => o.DonHangSanPham).Include(o => o.SanPham).FirstOrDefaultAsync(p => p.DonHangId == donHangId);
            var s = await _context.DonHang.FirstOrDefaultAsync(q => q.DonHangId == donHangId);
            var createResult = await _context.DonHang.FirstOrDefault(o => o.DonHangId == donHangId)
            return createResult is not null;
        }
        //update dia chi, shipper tong tien cua don hang
        public async Task<bool> shipping(CartRequest gh, Guid userId)
        {
            var createResult = await _context.DonHang.FirstOrDefault(o => o.DonHangId == donHangId)
            return createResult is not null;
        }
    }
}