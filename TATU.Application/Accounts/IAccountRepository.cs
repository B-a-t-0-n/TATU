using TATU.Domain;

namespace TATU.Application.Accounts
{
    public interface IAccountRepository
    {
        Task CreateAccountManager(Manager manager);
        Task<Account> GetById(Guid id);
        Task<Guid> Save(Account account);
        Task Delete(Account account);
    }
}
