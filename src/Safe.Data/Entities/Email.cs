using System;

namespace Self.Data.Entities
{
    public class Email
    {
        public int ID { get; set; }
        public int ServiceID { get; set; }
        public string Address { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Service Service { get; set; }
    }
}