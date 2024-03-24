namespace Shared.DTOs;

public class PostCreateDto
{
    public string Title { get; set; } = null!;
    public string Desc { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string LinkForPost { get; set; } = string.Empty;
    public int CategoryId { get; set; } = 0;
    public string Type { get; set; } = null!;
}