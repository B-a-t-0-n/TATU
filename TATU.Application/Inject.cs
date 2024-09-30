using Microsoft.Extensions.DependencyInjection;
using TATU.Application.Accounts.AddClient;
using TATU.Application.Accounts.Create;
using TATU.Application.Masters.Create;
using TATU.Application.Masters.Update;
using TATU.Application.Services.Create;

namespace TATU.Application
{
    public static class Inject
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<CreateAccountManagerHandler>();
            services.AddScoped<AddOrderHandler>();
            services.AddScoped<CreateMasterHandler>();
            services.AddScoped<UpdateMasterHandler>();
            services.AddScoped<CreateServicesHandler>();

            return services;
        }
    }
}
