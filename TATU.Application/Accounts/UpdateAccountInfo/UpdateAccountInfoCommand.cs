namespace TATU.Application.Accounts.UpdateAccountInfo
{
    public record UpdateAccountInfoCommand(Guid AccountId, string Login, string Password);
}
