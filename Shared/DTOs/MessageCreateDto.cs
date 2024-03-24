namespace Shared.DTOs;

public class MessageCreateDto
{
    public string RecipientUsername { get; set; } = null!;
    public string Content { get; set; } = null!;
}