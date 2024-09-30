using TATU.Application.DTO;

namespace TATU.Application.Accounts.Create
{
    public record CreateAccountManagerCommand(string Login, string Password, ManagerDto Manager);
}
