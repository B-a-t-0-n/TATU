using Microsoft.EntityFrameworkCore;
using TATU.Application.Masters;
using TATU.Domain;

namespace TATU.Infrastructure.Repository
{
    public class MasterRepository : IMasterRepository
    {
        private readonly ApplicationDbContext _context;

        public MasterRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public async Task Create(Master master)
        {
            await _context.Masters.AddAsync(master);
            await _context.SaveChangesAsync();
        }

        public async Task<Master> GetById(Guid id)
        {
            var master = await _context.Masters.FirstOrDefaultAsync(m => m.Id == id);
            if (master is null)
                return new Master();

            return master;
        }

        public async Task<Guid> Save(Master master)
        {
            _context.Masters.Attach(master);

            await _context.SaveChangesAsync();

            return master.Id;
        }

        public async Task Delete(Master master)
        {
            _context.Masters.Attach(master);
            _context.Masters.Remove(master);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Master>> GetAll()
        {
            var masters = await _context.Masters.ToListAsync();
            return masters;
        }
    }
}
