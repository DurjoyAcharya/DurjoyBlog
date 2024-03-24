using System.ComponentModel.DataAnnotations;

namespace Shared.DTOs;

public class RegisterDto
{
    [Required] public string UserName { get; set; } = null!;
    [Required] public string FirstName { get; set; } = null!;
    [Required] public string LastName { get; set; } = null!;
    [Required] public string Email { get; set; } = null!;

    [Required]
    [StringLength(20, MinimumLength =6)]
    public string Password { get; set; } = null!;
}