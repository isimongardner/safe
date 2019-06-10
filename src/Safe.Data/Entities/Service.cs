using Self.Data.Types;
using System;

namespace Self.Data.Entities
{
    public class Service
    {
        public int ID { get; set; }
        public string Domain { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public ServiceType Type { get; set; }
    }
}