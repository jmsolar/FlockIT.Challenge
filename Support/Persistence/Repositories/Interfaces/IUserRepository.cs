using Support.DTOs;
using Support.Filters;
using System.Threading.Tasks;

namespace Support.Persistence.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<ApiResponse<UserResponse>> GetUserByFilter(UserFilter filter);
    }
}
