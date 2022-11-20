
namespace Content.Persistence.ORM.Queries.Entities.Content
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.Criteria;
    using Domain.Entities;
    using Domain.Enums;
    using Linq.AsyncQueryable.Abstractions.Factories;
    using Linq.Providers.Abstractions;
    using global::Queries.Abstractions;
    using Linq.AsyncQueryable.Abstractions;

    public class FindArticleBySearchUserIdAndTypeQuery :
        LinqAsyncQueryBase<Article, FindContentBySearchUserIdAndType, List<Article>>
    {
        private IAsyncQueryBuilder _asyncQueryBuilder;

        public FindArticleBySearchUserIdAndTypeQuery(
            ILinqProvider linqProvider,
            IAsyncQueryableFactory asyncQueryableFactory, IAsyncQueryBuilder asyncQueryBuilder) : base(linqProvider, asyncQueryableFactory)
        {
            _asyncQueryBuilder = asyncQueryBuilder;
        }


        public override Task<List<Article>> AskAsync(
            FindContentBySearchUserIdAndType criterion,
            CancellationToken cancellationToken = default)
        {
            IQueryable<Article> query = Query;

            if (criterion.UserId.HasValue)
            {
                query = query.Where(x => x.Creator.Id == criterion.UserId);
            }

            if (!string.IsNullOrWhiteSpace(criterion.Search))
            {
                query = query.Where(x => x.Title.Contains(criterion.Search) || x.Text.Contains(criterion.Search));
            }

            query = query.OrderBy(x => x.Title);

            return ToAsync(query).ToListAsync(cancellationToken);
        }
    }
    }

