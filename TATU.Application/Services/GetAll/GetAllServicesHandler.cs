using TATU.Application.Masters;
using TATU.Domain;

namespace TATU.Application.Services.GetAll
{
    public class GetAllServicesHandler
    {
        private readonly IServicesRepository _servicesRepository;

        public GetAllServicesHandler(IServicesRepository servicesRepository)
        {
            _servicesRepository = servicesRepository;
        }

        public async Task<List<Domain.Services>> Handle()
        {
            var services = await _servicesRepository.GetAll();

            return services;
        }
    }
}
