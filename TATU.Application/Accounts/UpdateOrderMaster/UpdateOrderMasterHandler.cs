using TATU.Application.Masters;
using TATU.Domain;

namespace TATU.Application.Accounts.UpdateOrderMaster
{
    public class UpdateOrderMasterHandler
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMasterRepository _masterRepository;

        public UpdateOrderMasterHandler(IAccountRepository accountRepository, IMasterRepository masterRepository)
        {
            _accountRepository = accountRepository;
            _masterRepository = masterRepository;
        }

        public async Task<Guid> Handle(UpdateOrderMasterCommand command)
        {
            var account = await _accountRepository.GetById(command.ManagerId)
                ?? throw new ArgumentNullException("manager is null");

            if (account is Manager == false)
                throw new Exception("Account is not manager");

            var manager = account as Manager;

            var order = manager!.Orders!.FirstOrDefault(o => o.Id == command.OrderId)
                ?? throw new ArgumentNullException("order is null");

            var master = await _masterRepository.GetById(command.MasterId) 
                ?? throw new ArgumentNullException("master is null");

            order.Master = master;

            await _accountRepository.Save(manager!);

            return order.Id;
        }
    }
}
