namespace TATU.Application.Accounts.DeleteOrder
{
    public record DeleteOrderCommand(Guid OrderId, Guid ManagerId);
}
