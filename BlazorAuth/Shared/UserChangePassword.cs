using System.ComponentModel.DataAnnotations;

namespace BlazorAuth.Shared;

public class UserChangePassword
{
    [Required, StringLength(100, MinimumLength = 5)]
    public string Password { get; set; } = string.Empty;
    [Compare("Password", ErrorMessage = "The password do not match")]
    public string ConfirmPassword { get; set; } = string.Empty;
}