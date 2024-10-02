using TATU.Domain;

namespace TATU.Application.Accounts.UpdateOrderClient
{
    public class UpdateOrderClientHandler
    {
        private readonly IAccountRepository _accountRepository;

        public UpdateOrderClientHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<Guid> Handle(UpdateOrderClientCommand command)
        {
            var account = await _accountRepository.GetById(command.ManagerId)
                ?? throw new ArgumentNullException("manager is null");

            if (account is Manager == false)
                throw new Exception("Account is not manager");

            var manager = account as Manager;

            var order = manager!.Orders!.FirstOrDefault(o => o.Id == command.OrderId)
                ?? throw new ArgumentNullException("order is null");

            var client = new Client()
            {
                Id = Guid.NewGuid(),
                Name = command.Client.Name,
                Surname = command.Client.Surname,
                Patronymic = command.Client.Patronymic,
            };

            order.Client = client;

            await _accountRepository.Save(manager!);

            return order.Id;
        }
    }
}
