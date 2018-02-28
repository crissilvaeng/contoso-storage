using System.ComponentModel.DataAnnotations;

namespace Contoso.Application.Requests
{
    public class UserRequest
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "Name is too long. Maximun length is 100.")]
        public string Name { get; set; }

        [EmailAddress]
        [MaxLength(100, ErrorMessage = "Email is too long. Maximun length is 100.")]
        [Required(ErrorMessage = "E-mail is required.")]
        public string Email { get; set; }

        [MinLength(16, ErrorMessage = "Password is too short. Minimun length is 16.")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}