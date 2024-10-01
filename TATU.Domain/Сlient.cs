namespace TATU.Domain
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string? Patronymic { get; set; } = default!;
    }
}
