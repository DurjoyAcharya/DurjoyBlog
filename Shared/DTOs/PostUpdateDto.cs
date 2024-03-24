namespace Shared.DTOs;

public class PostUpdateDto
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Desc { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string Type { get; set; } = null!;
    public string? LinkForPost { get; set; } = string.Empty;
}