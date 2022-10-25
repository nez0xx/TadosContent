
namespace Content.Persistence.ORM.Queries.Entities.City
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.Criteria;
    using Domain.Entities;
    using Linq.AsyncQueryable.Abstractions.Factories;
    using Linq.Providers.Abstractions;

    public class FindCitiesBySearchQuery :
        LinqAsyncQueryBase<City, FindBySearch, List<City>>
    {
        public FindCitiesBySearchQuery(
            ILinqProvider linqProvider,
            IAsyncQueryableFactory asyncQueryableFactory) : base(linqProvider, asyncQueryableFactory)
        {
        }


        public override Task<List<City>> AskAsync(
            FindBySearch criterion,
            CancellationToken cancellationToken = default)
        {
            IQueryable<City> query = Query;
            

            if (!string.IsNullOrWhiteSpace(criterion.Search))
            {
                query = query.Where(x => x.Name.Contains(criterion.Search));
            }

            query = query.OrderBy(x => x.Name);

            return ToAsync(query).ToListAsync(cancellationToken);
        }
    }
}
