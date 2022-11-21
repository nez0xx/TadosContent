
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

    public class FindContentBySearchUserIdAndTypeQuery :
        LinqAsyncQueryBase<Content, FindContentBySearchUserIdAndType, List<Content>>
    {
        private IAsyncQueryBuilder _asyncQueryBuilder;

        public FindContentBySearchUserIdAndTypeQuery(
            ILinqProvider linqProvider,
            IAsyncQueryableFactory asyncQueryableFactory, IAsyncQueryBuilder asyncQueryBuilder) : base(linqProvider, asyncQueryableFactory)
        {
            _asyncQueryBuilder = asyncQueryBuilder;
        }


        public override async Task<List<Content>> AskAsync(
            FindContentBySearchUserIdAndType criterion,
            CancellationToken cancellationToken = default)
        {
            IQueryable<Content> query = Query;

            List<Content> content = new List<Content>();

            if (criterion.Type.HasValue)
            {   

                if (criterion.Type == ContentType.Article)
                {
                    List<Article> contentQuery = await _asyncQueryBuilder
                    .For<List<Article>>()
                    .WithAsync(new FindContentBySearchAndUserId(criterion.UserId, criterion.Search));

                    content = content.Concat(contentQuery).ToList();
                }
                if (criterion.Type == ContentType.Video)
                {
                    List<Video> contentQuery = await _asyncQueryBuilder
                    .For<List<Video>>()
                    .WithAsync(new FindContentBySearchAndUserId(criterion.UserId, criterion.Search));

                    content = content.Concat(contentQuery).ToList();
                }
                if (criterion.Type == ContentType.Gallery)
                {
                    List<Gallery> contentQuery = await _asyncQueryBuilder
                    .For<List<Gallery>>()
                    .WithAsync(new FindContentBySearchAndUserId(criterion.UserId, criterion.Search));

                    content = content.Concat(contentQuery).ToList();
                }
            }

           
            else if(!string.IsNullOrWhiteSpace(criterion.Search))
            {

                List<Article> articles = await _asyncQueryBuilder
                    .For<List<Article>>()
                    .WithAsync(new FindContentBySearchAndUserId(criterion.UserId, criterion.Search));


                content = content.Concat(articles).ToList();

                List<Video> videos = await _asyncQueryBuilder
                    .For<List<Video>>()
                    .WithAsync(new FindContentBySearchAndUserId(criterion.UserId, criterion.Search));

                content = content.Concat(videos).ToList();

                List<Gallery> galleries = await _asyncQueryBuilder
                    .For<List<Gallery>>()
                    .WithAsync(new FindContentBySearchAndUserId(criterion.UserId, criterion.Search));

                content = content.Concat(galleries).ToList();
            }

                return content;

            }
        }
    }

