using TATU.Domain;

namespace TATU.Application.Masters.GetById
{
    public class GetByIdMasterHandler
    {
        private readonly IMasterRepository _masterRepository;

        public GetByIdMasterHandler(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }

        public async Task<Master> Handle(Guid id)
        {
            var master = await _masterRepository.GetById(id);

            return master;
        }
    }
}
