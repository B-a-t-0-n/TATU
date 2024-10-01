using TATU.Application.DTO;

namespace TATU.Application.Accounts.UpdateManagerMainInfo
{
    public record UpdateOrderClientCommand(Guid ManagerId, ManagerDto Manager);
}
