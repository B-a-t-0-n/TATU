using TATU.Application.Accounts.UpdateOrderMaster;
using TATU.Application.Masters;
using TATU.Application.Services;
using TATU.Domain;

namespace TATU.Application.Accounts.UpdateOrderServices
{
    public class UpdateOrderServicesHandler
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IServicesRepository _servicesRepository;

        public UpdateOrderServicesHandler(IAccountRepository accountRepository, IServicesRepository servicesRepository)
        {
            _accountRepository = accountRepository;
            _servicesRepository = servicesRepository;
        }

        public async Task<Guid> Handle(UpdateOrderServicesCommand command)
        {
            var account = await _accountRepository.GetById(command.ManagerId)
                ?? throw new ArgumentNullException("manager is null");

            if (account is Manager == false)
                throw new Exception("Account is not manager");

            var manager = account as Manager;

            var order = manager!.Orders!.FirstOrDefault(o => o.Id == command.OrderId)
                ?? throw new ArgumentNullException("order is null");

            var service = await _servicesRepository.GetById(command.ManagerId)
                ?? throw new ArgumentNullException("service is null");

            order.Services = service;

            await _accountRepository.Save(manager!);

            return order.Id;
        }
    }
}
