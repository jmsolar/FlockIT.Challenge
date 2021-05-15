using Support.DTOs;
using Support.Filters;
using System.Threading.Tasks;

namespace TechnicalAPI.Services.Interfaces
{
    public interface IUserCustomService
    {
        Task<ApiResponse<UserResponse>> GetUserByFilter(UserFilter filter);
    }
}
