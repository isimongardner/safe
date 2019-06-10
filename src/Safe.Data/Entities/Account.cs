using System;

namespace Self.Data.Entities
{
    public class Account
    {
        public int ID { get; set; }
        public int ServiceID { get; set; }
        public int EmailID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ProfileURL { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Service Service { get; set; }
        public Email Email { get; set; }
    }
}