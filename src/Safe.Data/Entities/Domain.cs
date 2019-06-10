using System;

namespace Self.Data.Entities
{
    public class Domain
    {
        public string Name { get; set; }
        public DateTime Purchased { get; set; }
        public DateTime Renewal { get; set; }
        public double Price { get; set; }
        public double Renew { get; set; }
    }
}