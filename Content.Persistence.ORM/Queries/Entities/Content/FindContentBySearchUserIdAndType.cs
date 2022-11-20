
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
                    IAsyncQueryable<Article> contentQuery = await _asyncQueryBuilder
                    .For<IAsyncQueryable<Article>>()
                    .WithAsync(new FindArticlesBySearchAndUserId(criterion.UserId, criterion.Search));

                    content.Concat(await contentQuery.ToListAsync());
                }
                if (criterion.Type == ContentType.Video)
                {
                    IAsyncQueryable<Video> contentQuery = await _asyncQueryBuilder
                    .For<IAsyncQueryable<Video>>()
                    .WithAsync(new FindVideosBySearchAndUserId(criterion.UserId, criterion.Search));

                    content.Concat(await contentQuery.ToListAsync());
                }
                if (criterion.Type == ContentType.Gallery)
                {
                    IAsyncQueryable<Gallery> contentQuery = await _asyncQueryBuilder
                    .For<IAsyncQueryable<Gallery>>()
                    .WithAsync(new FindGalleriesBySearchAndUserId(criterion.UserId, criterion.Search));

                    content.Concat(await contentQuery.ToListAsync());
                }
            }

           
            else if(!string.IsNullOrWhiteSpace(criterion.Search))
            {
                
                IAsyncQueryable<Article> articles = await _asyncQueryBuilder
                    .For<IAsyncQueryable<Article>>()
                    .WithAsync(new FindArticlesBySearchAndUserId(criterion.UserId, criterion.Search));


                content = (List<Content>)content.Concat(await articles.ToListAsync());

                IAsyncQueryable<Video> videos = await _asyncQueryBuilder
                    .For<IAsyncQueryable<Video>>()
                    .WithAsync(new FindVideosBySearchAndUserId(criterion.UserId, criterion.Search));

                content = (List<Content>)content.Concat(await videos.ToListAsync());

                IAsyncQueryable<Gallery> galleries = await _asyncQueryBuilder
                    .For<IAsyncQueryable<Gallery>>()
                    .WithAsync(new FindGalleriesBySearchAndUserId(criterion.UserId, criterion.Search));

                content = (List<Content>)content.Concat(await galleries.ToListAsync());
            }

                 
                query = query.OrderBy(x => x.Id);

                return content;
            }
        }
    }

