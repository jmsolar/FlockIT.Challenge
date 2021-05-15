using Support.DTOs;
using System.Threading.Tasks;

namespace TechnicalAPI.Services.Interfaces
{
    public interface IStateService
    {
        Task<ApiResponse<StateResponse>> GetStateByName(string nombre);
    }
}
