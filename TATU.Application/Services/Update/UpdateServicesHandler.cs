using TATU.Application.Masters.Update;
using TATU.Application.Masters;

namespace TATU.Application.Services.Update
{
    public class UpdateServicesHandler
    {
        private readonly IServicesRepository _servicrsRepository;

        public UpdateServicesHandler(IServicesRepository servicrsRepository)
        {
            _servicrsRepository = servicrsRepository;
        }

        public async Task<Guid> Handle(UpdateServicesCommand command)
        {
            var services = await _servicrsRepository.GetById(command.ServicesId)
                ?? throw new ArgumentNullException("services is null");

            var title = command.Services.Title;
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException("Services.title is null or white space");

            services.Title = title;
            services.Description = command.Services.Description;

            await _servicrsRepository.Save(services);

            return services.Id;
        }
    }
}
