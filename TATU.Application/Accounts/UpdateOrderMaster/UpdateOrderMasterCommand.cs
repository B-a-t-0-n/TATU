namespace TATU.Application.Accounts.UpdateOrderMaster
{
    public record UpdateOrderMasterCommand(Guid ManagerId, Guid OrderId, Guid MasterId);
}
