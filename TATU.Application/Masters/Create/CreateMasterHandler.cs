using TATU.Domain;

namespace TATU.Application.Masters.Create
{
    public class CreateMasterHandler
    {
        private readonly IMasterRepository _masterRepository;

        public CreateMasterHandler(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }

        public async Task<Guid> Handle(CreateMasterCommand command)
        {
            var name = command.Master.Name;
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Master.name is null or white space");

            var surname = command.Master.Surname;
            if (string.IsNullOrWhiteSpace(surname))
                throw new ArgumentNullException("Master.surname is null or white space");

            var master = new Master()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Surname = surname,
                Patronymic = command.Master.Patronymic,
                WorkExperience = command.Master.WorkExperience,
                PhotoAvatarLink = command.Master.PhotoAvatarLink,
                Description = command.Master.Description,
                IsDismissed = command.Master.IsDismissed,
                PhotosWorksLink = command.Master.PhotosWorksLink,
            };

            await _masterRepository.Create(master);

            return master.Id;
        }
    }
}
