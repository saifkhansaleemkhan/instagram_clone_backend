using System.ComponentModel.DataAnnotations;

namespace Instander.Models
{
	public class User
    {
        public User() // Default constructor
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)] // Set maximum length for Username
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
