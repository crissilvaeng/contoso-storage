using System.Collections.Generic;

namespace Contoso.Domain.Models
{
    public class Organization : Entity
    {
        public string Name { get; set; }
        public long LimitUpload { get; set; }
        public long LimitStorage { get; set; }
        public User Administrator { get; set; }
        public IEnumerable<User> Members { get; set; }
    }
}