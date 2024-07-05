using System.ComponentModel.DataAnnotations;

namespace StrawpollCloneBackend.Entities
{
    public class User : Options
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public int RankValue { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string PasswordSalt { get; set; }
    }
}