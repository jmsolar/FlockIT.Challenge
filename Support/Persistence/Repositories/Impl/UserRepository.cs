using Microsoft.EntityFrameworkCore;
using Support.Domain;
using Support.Filters;
using Support.Persistence.Contexts;
using Support.Persistence.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Support.Persistence.Repositories.Impl
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly DbSet<User> _users;

        public UserRepository(ApplicationContext context) : base(context)
        {
            _users = context.Set<User>();
        }

        public async Task<User> GetUserByFilter(UserFilter filter) {
            return await _users.FindAsync(filter);
        }
    }
}
