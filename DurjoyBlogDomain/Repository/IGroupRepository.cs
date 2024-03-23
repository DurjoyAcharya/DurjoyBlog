using DurjoyBlogDomain.Entities;

namespace DurjoyBlogDomain.Repository;

public interface IGroupRepository
{
    void AddGroup(Group group);
    Task<Group> GetMsgGroup(string groupName);
    void RemoveConnection(Connection connection);
    Task<Connection> GetConnection(string connectionId);
}