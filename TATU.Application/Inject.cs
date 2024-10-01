using Microsoft.Extensions.DependencyInjection;
using TATU.Application.Accounts.AddClient;
using TATU.Application.Accounts.Create;
using TATU.Application.Accounts.Delete;
using TATU.Application.Accounts.DeleteOrder;
using TATU.Application.Accounts.GetAll;
using TATU.Application.Accounts.GetById;
using TATU.Application.Accounts.UpdateAccountInfo;
using TATU.Application.Accounts.UpdateManagerMainInfo;
using TATU.Application.Accounts.UpdateOrderClient;
using TATU.Application.Accounts.UpdateOrderMainInfo;
using TATU.Application.Accounts.UpdateOrderMaster;
using TATU.Application.Accounts.UpdateOrderServices;
using TATU.Application.Masters.Create;
using TATU.Application.Masters.Delete;
using TATU.Application.Masters.GetAll;
using TATU.Application.Masters.GetById;
using TATU.Application.Masters.Update;
using TATU.Application.Services.Create;
using TATU.Application.Services.Delete;
using TATU.Application.Services.GetAll;
using TATU.Application.Services.GetById;
using TATU.Application.Services.Update;

namespace TATU.Application
{
    public static class Inject
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<CreateServicesHandler>();
            services.AddScoped<DeleteServicesHandler>();
            services.AddScoped<GetAllServicesHandler>();
            services.AddScoped<GetByIdServicesHandler>();
            services.AddScoped<UpdateServicesHandler>();

            services.AddScoped<CreateMasterHandler>();
            services.AddScoped<DeleteMasterHandler>();
            services.AddScoped<GetAllMasterHandler>();
            services.AddScoped<GetByIdMasterHandler>();
            services.AddScoped<UpdateMasterHandler>();

            services.AddScoped<AddOrderHandler>();
            services.AddScoped<CreateAccountManagerHandler>();
            services.AddScoped<DeleteAccountHandler>();
            services.AddScoped<DeleteOrderHandler>();
            services.AddScoped<GetAllAccountHandler>();
            services.AddScoped<GetByIdAccountHandler>();
            services.AddScoped<UpdateAccountInfoHandler>();
            services.AddScoped<UpdateManagerMainInfoHandler>();
            services.AddScoped<UpdateOrderClientHandler>();
            services.AddScoped<UpdateOrderMainInfoHandler>();
            services.AddScoped<UpdateOrderMasterHandler>();
            services.AddScoped<UpdateOrderServicesHandler>();

            return services;
        }
    }
}
