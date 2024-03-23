using DurjoyBlogDomain.Entities;

namespace DurjoyBlogDomain.Repository;

public interface ILikesRepository
{
    Task<UserLike> GetUserLike(int srcUserId, int targetUserId);
    Task<User> GetUserWithLikes(int userId);
}