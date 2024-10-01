namespace TATU.Application.Services.Delete
{
    public class DeleteServicesHandler
    {
        private readonly IServicesRepository _servicrsRepository;

        public DeleteServicesHandler(IServicesRepository servicrsRepository)
        {
            _servicrsRepository = servicrsRepository;
        }

        public async Task<Guid> Handle(DeleteServicesCommand command)
        {
            var services = await _servicrsRepository.GetById(command.Id)
                ?? throw new ArgumentNullException("services is null");

            await _servicrsRepository.Delete(services);

            return services.Id;
        }
    }
}
