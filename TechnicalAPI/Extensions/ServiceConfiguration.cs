using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Support.Persistence.Contexts;
using Support.Persistence.Repositories.Impl;
using Support.Persistence.Repositories.Interfaces;
using TechnicalAPI.Services;
using TechnicalAPI.Services.Interfaces;

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

        public static void AddCustomService(this IServiceCollection services) {
            #region UserService
            services.AddTransient(typeof(IUserCustomService), typeof(UserCustomServices));
            services.AddTransient<IUserCustomService, UserCustomServices>();
            #endregion

            #region StateService
            services.AddTransient(typeof(IStateService), typeof(StateService));
            services.AddTransient<IStateService, StateService>();
            #endregion
        }

        public static void AddHttpClientService(this IServiceCollection services) {
            services.AddHttpClient();
        }
    }
}
