using TATU.Domain;

namespace TATU.Application.Masters.GetAll
{
    public class GetAllMasterHandler
    {
        private readonly IMasterRepository _masterRepository;

        public GetAllMasterHandler(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }

        public async Task<List<Master>> Handle()
        {
            var masters = await _masterRepository.GetAll();

            return masters.ToList();
        }
    }
}
