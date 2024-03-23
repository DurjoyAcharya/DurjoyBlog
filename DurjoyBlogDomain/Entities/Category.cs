namespace DurjoyBlogDomain.Entities;

public class Category
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public virtual ICollection<Post>? Posts { get; set; }
}