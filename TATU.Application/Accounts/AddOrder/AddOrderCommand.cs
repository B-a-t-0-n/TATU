using TATU.Application.DTO;

namespace TATU.Application.Accounts.AddClient
{
    public record AddOrderCommand(
        Guid IdManager,
        ClientDto Client,
        Guid ServiceId,
        Guid MasterId,
        DateTime DateTimeRecording,
        string? PhotoLink,
        string? Note);
}
