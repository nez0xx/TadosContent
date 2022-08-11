namespace Content.WebApi.Infrastructure.Pagination
{
    using System.Collections.Generic;
    using System.Linq;


    public class PaginatedList<T>
    {
        public PaginatedList(int totalCount, IEnumerable<T> items)
        {
            TotalCount = totalCount;
            Items = items.ToList();
        }

        public int TotalCount { get; }

        public List<T> Items { get; }
    }
}