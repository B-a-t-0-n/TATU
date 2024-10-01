using TATU.Domain;

namespace TATU.Application.Accounts.UpdateManagerMainInfo
{
    public class UpdateManagerMainInfoHandler
    {
        private readonly IAccountRepository _accountRepository;

        public UpdateManagerMainInfoHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<Guid> Handle(UpdateOrderClientCommand command)
        {
            var account = await _accountRepository.GetById(command.ManagerId)
                ?? throw new ArgumentNullException("account is null");

            if (account is Manager == false)
                throw new Exception("Account is not manager");

            var manager = account as Manager;

            var name = command.Manager.Name;
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Manager.name is null or white space");

            var surname = command.Manager.Surname;
            if (string.IsNullOrWhiteSpace(surname))
                throw new ArgumentNullException("Manager.surname is null or white space");

            manager!.Name = name;
            manager!.Surname = surname;
            manager!.Patronymic = command.Manager.Patronymic;
            manager!.WorkExperience = command.Manager.WorkExperience;

            await _accountRepository.Save(manager);

            return manager.Id;
        }
    }
}
