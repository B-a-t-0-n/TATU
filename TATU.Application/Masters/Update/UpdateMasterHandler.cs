using TATU.Application.Masters.Create;
using TATU.Domain;

namespace TATU.Application.Masters.Update
{
    public class UpdateMasterHandler
    {
        private readonly IMasterRepository _masterRepository;

        public UpdateMasterHandler(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }

        public async Task<Guid> Handle(UpdateMasterCommand command)
        {
            var master = await _masterRepository.GetById(command.MasterId)
                ?? throw new ArgumentNullException("Master is null");

            var name = command.Master.Name;
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Master.name is null or white space");

            var surname = command.Master.Surname;
            if (string.IsNullOrWhiteSpace(surname))
                throw new ArgumentNullException("Master.surname is null or white space");

            master.Name = name;
            master.Surname = surname;
            master.Patronymic = command.Master.Patronymic;
            master.IsDismissed = command.Master.IsDismissed;
            master.Description = command.Master.Description;
            master.PhotoAvatarLink = command.Master.PhotoAvatarLink;
            master.PhotosWorksLink = command.Master.PhotosWorksLink;
            master.WorkExperience = command.Master.WorkExperience;

            await _masterRepository.Save(master);

            return master.Id;
        }
    }
}
