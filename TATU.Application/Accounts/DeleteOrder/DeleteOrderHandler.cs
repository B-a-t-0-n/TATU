using TATU.Domain;

namespace TATU.Application.Accounts.DeleteOrder
{
    public class DeleteOrderHandler
    {
        private readonly IAccountRepository _accountRepository;

        public DeleteOrderHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<Guid> Handle(DeleteOrderCommand command)
        {
            var account = await _accountRepository.GetById(command.ManagerId)
                ?? throw new ArgumentNullException("account is null");

            if (account is Manager == false)
                throw new Exception("Account is not manager");

            var manager = account as Manager;

            var order = manager!.Orders!.FirstOrDefault(o => o.Id == command.OrderId)
                ?? throw new ArgumentNullException("order is null");

            manager!.Orders!.Remove(order);

            await _accountRepository.Save(manager!);

            return order.Id;
        }
    }
}
