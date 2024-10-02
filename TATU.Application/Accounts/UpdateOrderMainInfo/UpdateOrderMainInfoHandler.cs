using TATU.Domain;

namespace TATU.Application.Accounts.UpdateOrderMainInfo
{
    public class UpdateOrderMainInfoHandler
    {
        private readonly IAccountRepository _accountRepository;

        public UpdateOrderMainInfoHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<Guid> Handle(UpdateOrderMainInfoCommand command)
        {
            var account = await _accountRepository.GetById(command.ManagerId)
                ?? throw new ArgumentNullException("manager is null");

            if (account is Manager == false)
                throw new Exception("Account is not manager");

            var manager = account as Manager;

            var order = manager!.Orders!.FirstOrDefault(o => o.Id == command.OrderId)
                ?? throw new ArgumentNullException("order is null");

            order.Note = command.Note;
            order.PhotoLink = command.PhotoLink;
            order.DateTimeRecording = command.DateTimeRecording;

            await _accountRepository.Save(manager!);

            return order.Id;
        }
    }
}
