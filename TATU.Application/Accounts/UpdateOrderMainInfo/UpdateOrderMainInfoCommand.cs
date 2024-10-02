namespace TATU.Application.Accounts.UpdateOrderMainInfo
{
    public record UpdateOrderMainInfoCommand(
        Guid ManagerId,
        Guid OrderId,
        DateTime DateTimeRecording,
        string? PhotoLink,
        string? Note);
}
