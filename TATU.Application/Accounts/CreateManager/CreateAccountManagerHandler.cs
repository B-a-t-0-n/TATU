using TATU.Application.Providers;
using TATU.Domain;

namespace TATU.Application.Accounts.Create
{
    public class CreateAccountManagerHandler
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IPasswordHasher _passwordHasher;

        public CreateAccountManagerHandler(IAccountRepository accountRepository, IPasswordHasher passwordHasher)
        {
            _accountRepository = accountRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<Guid> Handle(CreateAccountManagerCommand command)
        {
            var login = command.Login;
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentNullException("login is null or white space");

            var password = command.Password;
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException("password is null or white space");

            var passwordHash = _passwordHasher.Generate(password);

            var name = command.Manager.Name;
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Manager.name is null or white space");

            var surname = command.Manager.Surname;
            if (string.IsNullOrWhiteSpace(surname))
                throw new ArgumentNullException("Manager.surname is null or white space");

            var manager = new Manager()
            {
                Id = Guid.NewGuid(),
                Login = command.Login,
                PasswordHash = passwordHash,
                Name = name,
                Surname = surname,
                Patronymic = command.Manager.Patronymic,
                WorkExperience = command.Manager.WorkExperience,
            };

            await _accountRepository.CreateAccountManager(manager);

            return manager.Id;
        }
    }
}
