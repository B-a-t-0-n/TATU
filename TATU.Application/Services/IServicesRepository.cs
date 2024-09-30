namespace TATU.Application.Services
{
    internal interface IServicesRepository
    {
        Task Create(Domain.Services services);
        Task<Domain.Services> GetById(Guid id);
        Task<Guid> Save(Domain.Services services);
        Task Delete(Domain.Services services);
    }
}
