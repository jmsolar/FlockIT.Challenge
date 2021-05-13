using Support.Domain;
using Support.DTOs;
using Support.Filters;
using System.Threading.Tasks;

namespace TechnicalAPI.Services.Interfaces
{
    public interface IUserCustomServices
    {
        Task<ApiResponse<User>> GetUserByFilter(UserFilter filter);
    }
}
