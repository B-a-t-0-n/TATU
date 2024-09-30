using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TATU.Application.Accounts;
using TATU.Application.Masters;
using TATU.Application.Providers;
using TATU.Application.Services;
using TATU.Infrastructure.Providers;
using TATU.Infrastructure.Repository;

namespace TATU.Infrastructure
{
    public static class Inject
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services)
        {
            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IMasterRepository, MasterRepository>();
            services.AddScoped<IServicesRepository, ServicesRepository>();

            services.AddTransient<IPasswordHasher, PasswordHasher>();

            return services;
        }
    }
}
