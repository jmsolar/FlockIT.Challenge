using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Support.Domain;

namespace Support.Persistence.Seeds
{
    public class UserSeeds : IEntityTypeConfiguration<User>
    {
        private EntityTypeBuilder<User> _builder;
        
        private void Seed() {
            this._builder.HasData(
                new User() { username = "Juan", email = "juan@juan.com" },
                new User() { username = "Lucrecia", email = "lucrecia@lucrecia.com" },
                new User() { username = "Maria", email = "maria@maria.com" },
                new User() { username = "Esteban", email = "esteban@esteban.com" },
                new User() { username = "Pilar", email = "pilar@pilar.com" }
            );
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            this._builder = builder;
            Seed();
        }
    }
}
