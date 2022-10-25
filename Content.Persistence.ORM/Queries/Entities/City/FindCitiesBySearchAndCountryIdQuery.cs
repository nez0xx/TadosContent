
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

    public class FindCitiesBySearchAndCountryIdQuery :
        LinqAsyncQueryBase<City, FindCitiesBySearchAndCountryId, List<City>>
    {
        public FindCitiesBySearchAndCountryIdQuery(
            ILinqProvider linqProvider,
            IAsyncQueryableFactory asyncQueryableFactory) : base(linqProvider, asyncQueryableFactory)
        {
        }


        public override Task<List<City>> AskAsync(
            FindCitiesBySearchAndCountryId criterion,
            CancellationToken cancellationToken = default)
        {
            IQueryable<City> query = Query;

            if (criterion.CountryId.HasValue)
            {
                query = query.Where(x => x.Country.Id == criterion.CountryId);
            }

            if (!string.IsNullOrWhiteSpace(criterion.Search))
            {
                query = query.Where(x => x.Name.Contains(criterion.Search));
            }

            query = query.OrderBy(x => x.Name);

            return ToAsync(query).ToListAsync(cancellationToken);
        }
    }
}
