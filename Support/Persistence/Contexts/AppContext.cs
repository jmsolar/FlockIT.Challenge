using Microsoft.EntityFrameworkCore;
using Support.Domain;

namespace Support.Persistence.Contexts
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            
        }

        // Define tables names
        public DbSet<User> users;

        public DbSet<State> states;
    }
}
