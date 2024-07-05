using System.ComponentModel.DataAnnotations;

namespace Entities;

public class User
{
    [Required]
    public int UserId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    [Required]
    public string PasswordSalt { get; set; }
}