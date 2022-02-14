using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ShopApiP223.Apps.AdminApi.DTOs.AccountDtos;
using ShopApiP223.Data.Entities;
using ShopApiP223.Services;
using System.Threading.Tasks;

namespace ShopApiP223.Apps.AdminApi.Controllers
{
    [ApiExplorerSettings(GroupName = "admin_v1")]
    [Route("admin/api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IJwtService _jwtService;
        private readonly IConfiguration _configuration;

        public AccountsController(UserManager<AppUser> userManager,IJwtService jwtService, IConfiguration configuration)
        {
            _userManager = userManager;
            _jwtService = jwtService;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {

            AppUser user = await _userManager.FindByNameAsync(loginDto.UserName);

            if (user == null)
                return NotFound();

            if (!await _userManager.CheckPasswordAsync(user, loginDto.Password))
                return NotFound();

            var roles = await _userManager.GetRolesAsync(user);

            string tokenStr = _jwtService.Genereate(user, roles, _configuration);

            return Ok(new { token = tokenStr });
        }
    }
}
