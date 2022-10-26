namespace Content.WebApi.Controllers.Content.Actions.Create
{
    using System;
    using System.Threading.Tasks;
    using Domain.Entities;
    using Domain.Services.Content.Articles;
    using Queries.Abstractions;

    public class CreateArticleHierarchicRequestHandler : ContentCreateHierarchicRequestHandler<CreateArticleHierarchicRequest>
    {
        private readonly IArticleService _articleService;



        public CreateArticleHierarchicRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, IArticleService articleService)
            : base(asyncQueryBuilder)
        {
            _articleService = articleService ?? throw new ArgumentNullException(nameof(articleService));
        }



        protected override async Task<Content> CreateContentAsync(
            string title,
            User user,
            CreateArticleHierarchicRequest request)
        {
            Article article = await _articleService.CreateArticleAsync(
                                                title: title,
                                                text: request.Text,
                                                creator: user);

            return article;
        }
    }
}
