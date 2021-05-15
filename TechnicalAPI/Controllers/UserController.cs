using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Support.DTOs;
using Support.Filters;
using System;
using System.Threading.Tasks;
using TechnicalAPI.Services.Interfaces;

namespace TechnicalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserCustomService _userService;

        public UserController(IUserCustomService userService) {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Login(LoginRequest request) {
            try
            {
                if (request == null) return BadRequest();

                var userFilter = new UserFilter() { email = request.email, username = request.username };

                var result = await _userService.GetUserByFilter(userFilter);

                if (result.Success)
                    return Ok(result);
                else
                    return NotFound(result.Errors);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error on authentication");
            }
        }
    }
}
