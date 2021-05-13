using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Support.Persistence.Contexts;
using Support.Persistence.Repositories.Impl;
using Support.Persistence.Repositories.Interfaces;
using Microsoft.OpenApi.Models;
using TechnicalAPI.Services.Interfaces;
using TechnicalAPI.Services;

namespace TechnicalAPI.Extensions
{
    public static class ServiceConfiguration
    {
        public static void AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(configuration.GetConnectionString("ApplicationConnection"), b => b.MigrationsAssembly("TechnicalAPI")));

            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUserRepository, UserRepository>();
            #endregion
        }

        public static void AddSwaggerDocumentation(this IServiceCollection services) {
            services.AddSwaggerGen(options =>
            {
                var version = "v1";

                options.SwaggerDoc(version, new OpenApiInfo
                {
                    Title = $"Flock IT {version}",
                    Version = version,
                    Description = "API - Interview",
                    Contact = new OpenApiContact
                    {
                        Name = "Solar Jonatan Matias",
                        Email = "matias.solar@outlook.com"
                    }
                });
            });
        }

        public static void AddCustomServices(this IServiceCollection services) {
            services.AddTransient(typeof(IUserCustomServices), typeof(UserCustomServices));
            services.AddTransient<IUserCustomServices, UserCustomServices>();
        }

    }
}
