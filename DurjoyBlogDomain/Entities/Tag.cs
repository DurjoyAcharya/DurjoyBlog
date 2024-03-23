using System.ComponentModel.DataAnnotations.Schema;

namespace DurjoyBlogDomain.Entities;

[Table("Tags")]
public class Tag
{
    public string? Name { get; set; }
    public string? Desc { get; set; }
    public string? Slug { get; set; }
    public List<PostTags>? PostTags { get; set; }
}