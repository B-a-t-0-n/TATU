namespace TATU.Domain
{
    public class Manager : Account
    {
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string? Patronymic { get; set; } = default!;
        public double WorkExperience { get; set; }
        public IList<Order>? Orders { get; set; }
    }
}
