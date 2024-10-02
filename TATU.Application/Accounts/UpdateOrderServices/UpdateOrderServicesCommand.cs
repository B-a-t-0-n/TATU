namespace TATU.Application.Accounts.UpdateOrderServices
{
    public record UpdateOrderServicesCommand(Guid ManagerId, Guid OrderId, Guid ServicesId);
}
