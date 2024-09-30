using TATU.Domain;

namespace TATU.Application.Accounts
{
    public interface IAccountRepository
    {
        Task CreateAccountManager(Manager manager); 
    }
}
