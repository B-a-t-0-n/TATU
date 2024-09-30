using TATU.Application.DTO;

namespace TATU.Application.Accounts.UpdateManagerMainInfo
{
    public record UpdateManagerMainInfoCommand(Guid ManagerId, ManagerDto Manager);
}
