using Support.Domain;
using Support.Filters;
using System.Threading.Tasks;

namespace Support.Persistence.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByFilter(UserFilter filter);
    }
}
