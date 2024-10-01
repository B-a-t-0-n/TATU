using TATU.Domain;

namespace TATU.Application.Accounts.GetById
{
    public class GetByIdAccountHandler
    {
        private readonly IAccountRepository _accountRepository;

        public GetByIdAccountHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<Account> Handle(Guid id)
        {
            var account = await _accountRepository.GetById(id);

            return account;
        }
    }
}
