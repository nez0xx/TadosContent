namespace Content.WebApi.Controllers.Content.Actions.Edit
{
    using System;
    using System.Threading.Tasks;
    using Domain.Entities;
    using Domain.Criteria;
    using Domain.Services.Content.Videos;
    using Queries.Abstractions;

    public class ArticleEditHierarchicRequestHandler : ContentEditHierarchicRequestHandler<ArticleEditHierarchicRequest>
    {
        IAsyncQueryBuilder _asyncQueryBuilder;

        public ArticleEditHierarchicRequestHandler(IAsyncQueryBuilder asyncQueryBuilder)
            : base(asyncQueryBuilder)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
        }



        protected override async Task EditContentAsync(
            long id,
            ArticleEditHierarchicRequest request)
        {
            Article article = await _asyncQueryBuilder
                .For<Article>()
                .WithAsync(new FindById(id)); 
                
            if (article == null) throw new ArgumentNullException(nameof(id));
             
            if (request.Title != null) article.SetTitle(request.Title);

            if (request.Text != null) article.SetText(request.Text);
        }
    }
}
