using DurjoyBlogDomain.Entities;

namespace DurjoyBlogDomain.Repository;

public interface ITagRepository:IRepository<Tag>
{
    Task Delete(Tag tag);
    Task Update(Tag tag);
    Task<IEnumerable<Tag>> GetAll();
    Task<Tag> FindbyTagName(string tagName);
}