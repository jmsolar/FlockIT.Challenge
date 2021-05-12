using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Support.Persistence.Contexts;
using Support.Persistence.Repositories.Impl;
using Support.Persistence.Repositories.Interfaces;

namespace TechnicalAPI.Extensions
{
    public static class Service
    {
        public static void AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(configuration.GetConnectionString("ApplicationConnection"), b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));

            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUserRepository, UserRepository>();
            #endregion
        }
    }
}
