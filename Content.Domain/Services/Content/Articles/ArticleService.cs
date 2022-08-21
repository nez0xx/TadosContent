namespace Content.Domain.Services.Content.Articles
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Commands.Contexts;
    using Entities;
    using Enums;
    using global::Commands.Abstractions;
    using Queries.Abstractions;

    public class ArticleService : IArticleService
    {
        private readonly IAsyncCommandBuilder _asyncCommandBuilder;

        public ArticleService(IAsyncQueryBuilder asyncQueryBuilder, IAsyncCommandBuilder asyncCommandBuilder) 
        {
            _asyncCommandBuilder = asyncCommandBuilder ?? throw new ArgumentNullException(nameof(asyncCommandBuilder));
        }


        public async Task<Article> CreateArticleAsync(string title, string text, CancellationToken cancellationToken = default)
        {


            Article article = new Article(title, text);

            await _asyncCommandBuilder.CreateAsync(article, cancellationToken);

            return article;
        }
    }
}