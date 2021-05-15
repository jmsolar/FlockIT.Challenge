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
                new User() { Id = Guid.NewGuid(), username = "Juan", password = "juan123" },
                new User() { Id = Guid.NewGuid(), username = "Lucrecia", password = "lucrecia123" },
                new User() { Id = Guid.NewGuid(), username = "Maria", password = "maria123" },
                new User() { Id = Guid.NewGuid(), username = "Esteban", password = "esteban123" },
                new User() { Id = Guid.NewGuid(), username = "Pilar", password = "pilar123" }
            );
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            this._builder = builder;
            Seed();
        }
    }
}
