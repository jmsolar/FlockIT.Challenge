using Support.DTOs;
using Support.Filters;
using Support.Persistence.Repositories.Impl;
using System.Threading.Tasks;

namespace TechnicalAPI.Business
{
    public class UserBusiness
    {
        private UserRepository _userRepository;
        public UserBusiness(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<string> Authenticate(LoginRequest request) {
            var filter = new UserFilter() { 
                email = request.email,
                username = request.username
            };

            var result = await _userRepository.GetUserByFilter(filter);
            return "123";
        }
    }
}
