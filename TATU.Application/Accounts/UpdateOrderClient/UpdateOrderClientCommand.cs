using TATU.Application.DTO;

namespace TATU.Application.Accounts.UpdateOrderClient
{
    public record UpdateOrderClientCommand(Guid ManagerId, Guid OrderId, ClientDto Client);
}
