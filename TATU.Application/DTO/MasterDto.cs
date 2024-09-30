
namespace TATU.Application.DTO
{
    public record MasterDto(
        string Name,
        string Surname,
        string? Patronymic,
        double WorkExperience,
        string? Description,
        bool IsDismissed,
        string? PhotoAvatarLink,
        IEnumerable<string>? PhotosWorksLink);
    
}
