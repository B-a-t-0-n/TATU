namespace TATU.Domain
{
    public class Master
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string? Patronymic { get; set; } = default!;
        public double WorkExperience { get; set; }
        public string? Description { get; set; } = default!;
        public IList<Order>? Orders { get; set; }
        public bool IsDismissed { get; set; } = false;
        public string? PhotoAvatarLink { get; set; }
        public IEnumerable<string>? PhotosWorksLink { get; set; }

    }
}
