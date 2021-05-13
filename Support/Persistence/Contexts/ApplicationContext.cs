using Microsoft.EntityFrameworkCore;
using Support.Domain;
using Support.Persistence.Seeds;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserSeeds());
        }
    }
}
