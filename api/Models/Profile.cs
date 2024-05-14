using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Last_Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [StringLength(20)]
        public string Post_Code { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(255)]
        public string Address { get; set; }
    }
}
