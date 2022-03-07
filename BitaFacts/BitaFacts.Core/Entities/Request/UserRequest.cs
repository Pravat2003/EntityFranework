using System.ComponentModel.DataAnnotations;

namespace BitaFacts.Core.Entities.Request
{
    public class UserRequest
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
