using DurjoyBlogDomain.Entities;

namespace DurjoyBlogDomain.Repository;

public interface ICategoryRepository:IRepository<Category>
{
    Task<IEnumerable<Category>> GetCategoriesAsync();
}