namespace Content.Domain.Services.Content.Articles
{
    using System.Threading;
    using System.Threading.Tasks;
    using Entities;
    using global::Domain.Abstractions;
    public interface IArticleService : IDomainService
    {
        Task<Article> CreateArticleAsync(
            string title,
            string text,
            CancellationToken cancellationToken = default);
        Task UpdateArticleAsync(Article article, long id,
            CancellationToken cancellationToken = default);
    }
}

