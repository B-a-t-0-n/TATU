namespace TATU.Application.Services.Create
{
    public class CreateServicesHandler
    {
        private readonly IServicesRepository _servicesRepository;

        public CreateServicesHandler(IServicesRepository servicesRepository)
        {
            _servicesRepository = servicesRepository;
        }

        public async Task<Guid> Handle(CreateServicesCommand command)
        {
            var title = command.Services.Title;
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException("Services.title is null or white space");

            var services = new Domain.Services()
            {
                Id = Guid.NewGuid(),
                Title = title,
                Description = command.Services.Description,
            };

            await _servicesRepository.Create(services);

            return services.Id;
        }
    }
}
