using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        // Update the property name to match the database column name
        [ForeignKey("profile_id")]
        public int profile_id { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        // Navigation property for the associated profile
        public Profile Profile { get; set; }
    }
}
