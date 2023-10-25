
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EtecBookAPI.Models
{
    [Table("User")]
    public class AppUser
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string UserName { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 6)]
        public string Password { get; set; }

        public string Token { get; set; }

        public string Role { get; set; }

        [Required]
        [StringLength(300)]
        public string Email { get; set; }
        
        public string ProfilePicture { get; set; }
    }
}
