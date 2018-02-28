namespace Contoso.Domain.Models
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Algorithm { get; set; }
        public string[] Role { get; set; }
    }
}