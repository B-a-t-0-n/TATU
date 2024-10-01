using TATU.Domain;

namespace TATU.Application.Accounts.GetAll
{
    public class GetAllAccountHandler
    {
        private readonly IAccountRepository _accountRepository;

        public GetAllAccountHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<List<Account>> Handle()
        {
            var accounts = await _accountRepository.GetAll();

            return accounts;
        }
    }
}
