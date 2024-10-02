namespace TATU.Domain
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Login { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;
    }
}
