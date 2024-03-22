using Microsoft.AspNetCore.Identity;

namespace DurjoyBlogDomain.Entities;

public class AdminRole:IdentityRole<int>
{
    public ICollection<AdminUserRole> UserRoles { get; set; } = null!;
}