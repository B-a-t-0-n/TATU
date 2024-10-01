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
        public bool IsDismissed { get; set; } = false;
        public string? PhotoAvatarLink { get; set; }
        public string? PhotosWorksLink { get; set; }
        public IList<Order>? Orders { get; set; }
    }
}
