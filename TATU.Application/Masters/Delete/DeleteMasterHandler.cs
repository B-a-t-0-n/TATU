using TATU.Application.Masters.Update;

namespace TATU.Application.Masters.Delete
{
    public class DeleteMasterHandler
    {
        private readonly IMasterRepository _masterRepository;

        public DeleteMasterHandler(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }

        public async Task<Guid> Handle(DeleteMasterCommand command)
        {
            var master = await _masterRepository.GetById(command.Id)
                ?? throw new ArgumentNullException("Master is null");

            await _masterRepository.Delete(master);

            return master.Id;
        }
    }
}
