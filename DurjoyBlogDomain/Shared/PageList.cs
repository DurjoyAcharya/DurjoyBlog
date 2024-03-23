using Microsoft.EntityFrameworkCore;

namespace DurjoyBlogDomain.Shared;

public class PageList<E> : List<E>
{
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public PageList(IEnumerable<E> items, int count, int pageNum, int pageSize)
    {
        CurrentPage = pageNum;
        TotalPages = (int) Math.Ceiling(count / (double) pageSize);
        PageSize = pageSize;
        TotalCount = count;
        AddRange(items);
    }
    public static async Task<PageList<E>> CreateAsync(IQueryable<E> source, int pageNumber, int pageSize){
        var count = await source.CountAsync();
        var items = await source.Skip((pageNumber-1) * pageSize).Take(pageSize).ToListAsync();
        return new PageList<E>(items, count, pageNumber, pageSize);
    }
    public static PageList<E> CreateAsync(IEnumerable<E> source, int pageNumber, int pageSize)
    {
        var count = source.Count();
        var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        return new PageList<E>(items, count, pageNumber, pageSize);
    }
    
}