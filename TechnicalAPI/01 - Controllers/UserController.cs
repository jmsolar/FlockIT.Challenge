using Microsoft.AspNetCore.Mvc;
using Support.DTOs;
using System.Threading.Tasks;
using TechnicalAPI.Business;

namespace TechnicalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserBusiness _userBusiness;
        public UserController(UserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        [HttpPost("authenticate")]
        public IActionResult Login(LoginRequest request) {
            var result = _userBusiness.Authenticate(request);
            return Ok();
        }
    }
}
