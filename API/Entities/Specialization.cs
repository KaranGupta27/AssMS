using System.Collections.Generic;

namespace API.Entities
{
    public class Specialization
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<Associate> AssociateId { get; set; }
    }
}