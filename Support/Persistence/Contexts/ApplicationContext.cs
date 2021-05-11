using Microsoft.EntityFrameworkCore;
using Support.Domain;

namespace Support.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }

        // Define tables names
        public DbSet<User> users;

        public DbSet<State> states;
    }
}
