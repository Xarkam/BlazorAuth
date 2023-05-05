using System.ComponentModel.DataAnnotations;

namespace BlazorAuth.Shared;

public class UserLogin
{
    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;
    [Required]
    public string Password { get; set; }
}