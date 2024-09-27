﻿namespace TATU.Domain
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string? Patronymic { get; set; } = default!;
        public IList<Order>? Orders { get; set; }
    }
}
