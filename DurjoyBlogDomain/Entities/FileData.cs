using DurjoyBlogDomain.Params;
using DurjoyBlogDomain.Shared;

namespace DurjoyBlogDomain.Entities;

public class FileData: BaseEntity
{
    public int FileStorageId { get; set; }
    public string FileName { get; set; }
    public string FilePath { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    public virtual FileStorage FileStorage { get; set; }
}