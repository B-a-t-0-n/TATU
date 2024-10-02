namespace TATU.Application.Services.GetById
{
    public class GetByIdServicesHandler
    {
        private readonly IServicesRepository _servicesRepository;

        public GetByIdServicesHandler(IServicesRepository servicesRepository)
        {
            _servicesRepository = servicesRepository;
        }

        public async Task<Domain.Services> Handle(Guid id)
        {
            var services = await _servicesRepository.GetById(id);

            return services;
        }
    }
}
