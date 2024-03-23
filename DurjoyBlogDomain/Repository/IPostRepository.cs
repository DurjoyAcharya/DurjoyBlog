using DurjoyBlogDomain.Entities;

namespace DurjoyBlogDomain.Repository;

public interface IPostRepository:IRepository<Post>
{
    Task UpdateAsync(Post user);
    Task<IEnumerable<Post>> GetPostAsync();
    Task<Post> GetPostDetails(int id); 
    Task<IEnumerable<Post>> GetPostsAsync(int limit, int offset);   
    Task<IEnumerable<Post>> GetPostsByUserName(string userName);
}