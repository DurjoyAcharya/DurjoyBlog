namespace Shared.DTOs;

public class UserDto
{
    public string Username { get; set; } = null!;
    public string Token { get; set; } = null!;
    public string PhotoUrl {get; set; } = null!;
    public string KnownAs {get; set; } = null!;
    public string Gender { get; set; } = null!;
}