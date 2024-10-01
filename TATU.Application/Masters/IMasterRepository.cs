using TATU.Domain;

namespace TATU.Application.Masters
{
    public interface IMasterRepository
    {
        Task Create(Master manager);
        Task<Master> GetById(Guid id);
        Task<List<Master>> GetAll();
        Task<Guid> Save(Master master);
        Task Delete(Master master);
    }
}
