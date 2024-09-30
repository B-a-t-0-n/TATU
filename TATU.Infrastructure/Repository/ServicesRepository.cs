using Microsoft.EntityFrameworkCore;
using TATU.Application.Services;
using TATU.Domain;

namespace TATU.Infrastructure.Repository
{
    public class ServicesRepository : IServicesRepository
    {
        private readonly ApplicationDbContext _context;

        public ServicesRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public async Task Create(Services services)
        {
            await _context.Services.AddAsync(services);
        }

        public async Task<Services> GetById(Guid id)
        {
            var services = await _context.Services.FirstOrDefaultAsync(m => m.Id == id);
            if (services is null)
                return new Services();

            return services;
        }

        public async Task<Guid> Save(Services services)
        {
            _context.Services.Attach(services);

            await _context.SaveChangesAsync();

            return services.Id;
        }

        public async Task Delete(Services services)
        {
            _context.Services.Attach(services);
            _context.Services.Remove(services);

            await _context.SaveChangesAsync();
        }
    }
}
