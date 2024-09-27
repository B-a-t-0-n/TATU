namespace TATU.Domain
{
    public class Services
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; } = default!;
        public IList<Order>? Orders { get; set; }
    }
}
