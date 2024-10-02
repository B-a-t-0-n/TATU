namespace TATU.Application.Accounts.Delete
{
    public class DeleteAccountHandler
    {
        private readonly IAccountRepository _accountRepository;

        public DeleteAccountHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<Guid> Handle(DeleteAccountCommand command)
        {
            var manager = await _accountRepository.GetById(command.AccountId) 
                ?? throw new ArgumentNullException("manager is null");

            await _accountRepository.Delete(manager);

            return manager.Id;
        }
    }
}
