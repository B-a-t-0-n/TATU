using TATU.Application.DTO;

namespace TATU.Application.Accounts.AddClient
{
    public record AddOrderCommand(
        Guid IdManager,
        ClientDto Client,
        Guid IdService,
        Guid IdMaster,
        DateTime DateTimeRecording,
        string? PhotoLink,
        string? Note);
}
