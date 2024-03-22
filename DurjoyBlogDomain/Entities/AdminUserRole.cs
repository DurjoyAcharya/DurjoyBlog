using Microsoft.AspNetCore.Identity;

namespace DurjoyBlogDomain.Entities;

public class AdminUserRole:IdentityRole<int>
{
    public User user { get; set; }
    public AdminUserRole AdminUser { get; set; }
    
}
