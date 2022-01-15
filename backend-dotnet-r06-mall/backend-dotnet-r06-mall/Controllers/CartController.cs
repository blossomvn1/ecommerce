using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_dotnet_r06_mall.Contants;
using backend_dotnet_r06_mall.Models;
using backend_dotnet_r06_mall.Requests;
using backend_dotnet_r06_mall.Response;
using backend_dotnet_r06_mall.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace backend_dotnet_r06_mall.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly CartServices _service;
        private readonly ILogger<CartController> _logger;

        public CartController(CartServices service, ILogger<CartController> logger)
        {
            _service = service;
            _logger = logger;
        }

        // [HttpGet]
        // public async Task<IActionResult> GetProduct([FromQuery] ProductListRequest query)
        // {
        //     PagedList<SanPham> listProducts = await _service.GetProducts(query);
        //     return Ok(new PagedListResponse<SanPham>(listProducts));
        // }

        [HttpPost("Create")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = RoleConstants.Khach)]
        public async Task<IActionResult> TaoDonHang([FromBody] CartRequest gh)
        {
            Guid userId = new Guid(User.FindFirst("Id")?.Value);
            var dh = await _service.TaoDonHang(gh, userId);
            return dh ? Ok() : BadRequest();
        }

        // [HttpPatch("Pay")]
        // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = RoleConstants.Khach)]
        // public async Task<IActionResult> ThanhToan([FromBody] Guid cartId)
        // {
        //     Guid userId = new Guid(User.FindFirst("Id")?.Value);
        //     var temp = await _service.thanhToan(cartId,userId);
        //     return temp ? Ok(): BadRequest();
        // }

        // [HttpPost("Ship")]
        // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = RoleConstants.Khach)]
        // public async Task<IActionResult> Shipping([FromBody] CartRequest gh)
        // {
        //     Guid userId = new Guid(User.FindFirst("Id")?.Value);
        //     var dh = await _service.TaoDonHang(gh, userId);
        //     return dh ? Ok() : BadRequest();
        // }
    }
}