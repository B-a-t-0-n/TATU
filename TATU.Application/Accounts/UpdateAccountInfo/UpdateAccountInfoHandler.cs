using TATU.Application.Providers;

namespace TATU.Application.Accounts.UpdateAccountInfo
{
    public class UpdateAccountInfoHandler
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IPasswordHasher _passwordHasher;

        public UpdateAccountInfoHandler(IAccountRepository accountRepository, IPasswordHasher passwordHasher)
        {
            _accountRepository = accountRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<Guid> Handle(UpdateAccountInfoCommand command)
        {
            var account = await _accountRepository.GetById(command.AccountId)
                ?? throw new ArgumentNullException("account is null");

            var login = command.Login;
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentNullException("login is null or white space");

            var password = command.Password;
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException("password is null or white space");

            var passwordHash = _passwordHasher.Generate(password);

            account.Login = login;
            account.PasswordHash = passwordHash;

            await _accountRepository.Save(account);

            return account.Id;
        }

    }
}
