using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Support.Domain;
using System;

namespace Support.Persistence.Seeds
{
    public class UserSeeds : IEntityTypeConfiguration<User>
    {
        private EntityTypeBuilder<User> _builder;
        
        private void Seed() {
            this._builder.HasData(
                new User() { Id = Guid.NewGuid(), username = "Juan", email = "juan@juan.com" },
                new User() { Id = Guid.NewGuid(), username = "Lucrecia", email = "lucrecia@lucrecia.com" },
                new User() { Id = Guid.NewGuid(), username = "Maria", email = "maria@maria.com" },
                new User() { Id = Guid.NewGuid(), username = "Esteban", email = "esteban@esteban.com" },
                new User() { Id = Guid.NewGuid(), username = "Pilar", email = "pilar@pilar.com" }
            );
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            this._builder = builder;
            Seed();
        }
    }
}
