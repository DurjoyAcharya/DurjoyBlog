namespace Shared.DTOs;

public class TagDto
{
    public int TagId { get; set; }
    public string Name { get; set; } = null!;
    public string Desc { get; set; } = null!;
    public string Slug { get; set; } = null!;
}