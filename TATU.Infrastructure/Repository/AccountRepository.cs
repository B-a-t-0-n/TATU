using Microsoft.EntityFrameworkCore;
using TATU.Application.Accounts;
using TATU.Domain;

namespace TATU.Infrastructure.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public async Task CreateAccountManager(Manager manager)
        {
            await _context.Managers.AddAsync(manager);

            await _context.SaveChangesAsync();
        }

        public async Task<Account> GetById(Guid id)
        {
            var orders = _context.Managers.Include(m => m.Orders);

            if (orders == null)
            {
                var managerIsNullOrders = await _context.Managers.FirstOrDefaultAsync(m => m.Id == id);
                if (managerIsNullOrders == null)
                    return new Manager();

                return managerIsNullOrders;
            }

            var accountManager = await _context.Managers
                .Include(m => m.Orders)!
                .ThenInclude(o => o.Services)
                .Include(m => m.Orders)!
                .ThenInclude(o => o.Client)
                .Include(m => m.Orders)!
                .ThenInclude(o => o.Master)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (accountManager is null)
                return new Manager();

            return accountManager!;
        }

        public async Task<IEnumerable<Account>> GetAll()
        {
            var orders = _context.Managers.Include(m => m.Orders);

            if (orders == null)
            {
                var managersIsNullOrders = await _context.Managers.ToListAsync();
                if (managersIsNullOrders == null)
                    return new List<Account>();

                return managersIsNullOrders;
            }

            var accountsManager = await _context.Managers
                .Include(m => m.Orders)!
                .ThenInclude(o => o.Services)
                .Include(m => m.Orders)!
                .ThenInclude(o => o.Client)
                .Include(m => m.Orders)!
                .ThenInclude(o => o.Master)
                .ToListAsync();

            if (accountsManager is null)
                return new List<Account>();

            return accountsManager!;
        }

        public async Task<Guid> Save(Account account)
        {
            _context.Attach(account);

            await _context.SaveChangesAsync();

            return account.Id;
        }

        public async Task Delete(Account account)
        {
            _context.Attach(account);
            _context.Accounts.Remove(account);

            await _context.SaveChangesAsync();
        }
    }
}
