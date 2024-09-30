using TATU.Application.Masters;
using TATU.Application.Services;
using TATU.Domain;

namespace TATU.Application.Accounts.AddClient
{
    public class AddOrderHandler
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMasterRepository _masterRepository;
        private readonly IServicesRepository _servicesRepository;

        public AddOrderHandler(
            IAccountRepository accountRepository,
            IMasterRepository masterRepository,
            IServicesRepository servicesRepository)
        {
            _accountRepository = accountRepository;
            _masterRepository = masterRepository;
            _servicesRepository = servicesRepository;
        }

        public async Task<Guid> Handle(AddOrderCommand command)
        {
            var account = await _accountRepository.GetById(command.IdManager) 
                ?? throw new ArgumentNullException("manager is null");

            if (account is Manager == false)
                throw new Exception("Account is not manager");

            var manager = account as Manager;

            var name = command.Client.Name;
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Client.name is null or white space");

            var surname = command.Client.Surname;
            if (string.IsNullOrWhiteSpace(surname))
                throw new ArgumentNullException("Client.surname is null or white space");

            var client = new Client()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Surname = surname,
                Patronymic = command.Client.Patronymic
            };

            var service = await _servicesRepository.GetById(command.IdService);

            var master = await _masterRepository.GetById(command.IdManager);

            var order = new Order()
            {
                Id = Guid.NewGuid(),
                Client = client,
                Services = service,
                Master = master,
                DateTimeRecording = command.DateTimeRecording,
                Note = command.Note,
                PhotoLink = command.PhotoLink
            };

            manager!.Orders!.Add(order);

            await _accountRepository.Save(manager!);

            return client.Id;
        }
    }
}
