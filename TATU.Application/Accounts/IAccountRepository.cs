using TATU.Domain;

namespace TATU.Application.Accounts
{
    public interface IAccountRepository
    {
        Task CreateAccountManager(Manager manager);
        Task<Account> GetById(Guid id);
        Task<IEnumerable<Account>> GetAll();
        Task<Guid> Save(Account account);
        Task Delete(Account account);
    }
}
