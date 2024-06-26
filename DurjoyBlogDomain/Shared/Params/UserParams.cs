using DurjoyBlogDomain.Shared.Params;

namespace DurjoyBlogDomain.Params;

public class UserParams:PaginationParams
{
    public string CurrentUsername { get; set; }
    public string Gender { get; set; }        
    public int MinAge {get; set; } = 18;
    public int MaxAge { get; set; } = 90;
    public string OrderBy {get; set; } = "lastActive";
}