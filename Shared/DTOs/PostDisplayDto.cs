namespace Shared.DTOs;

public class PostDisplayDto
{
    public int Id {get; set;}
    public string Title { get; set; } = null!;
    public string Desc { get; set; } = null!;
    public string Status { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string LinkForPost { get; set; } = null!;
    public string Type { get; set; } = null!;
    public int Upvotes { get; set; }
    public string UserName { get; set; } = null!;
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
}