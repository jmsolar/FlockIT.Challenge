using Microsoft.AspNetCore.Mvc;
using Support.DTOs;
using System.Threading.Tasks;
using TechnicalAPI.Services.Interfaces;

namespace TechnicalAPI._01___Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {   
        private readonly IStateService _stateService;

        public StateController(IStateService stateService)
        {
            _stateService = stateService;
        }

        [HttpGet("info")]
        public async Task<ApiResponse<StateResponse>> GetStateByName([FromQuery] string name) 
        {
            return await _stateService.GetStateByName(name);            
        }
    }
}
