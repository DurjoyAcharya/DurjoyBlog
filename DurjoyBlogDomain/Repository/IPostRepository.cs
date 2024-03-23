using DurjoyBlogDomain.Entities;

namespace DurjoyBlogDomain.Repository;

public interface IPostRepository:IRepository<Post>
{
    Task UpdateAsync(Post user);
    Task<IEnumerable<Post>> GetPostAsync();
    
}