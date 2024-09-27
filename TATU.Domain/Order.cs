namespace TATU.Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public Services? Services { get; set; }
        public Client? Client { get; set; }
        public Manager? Manager { get; set; }   
        public DateTime DateTimeRecording { get; set; }
        public string? PhotoLink { get; set; }
        public string? Note { get; set; }
    }
}
