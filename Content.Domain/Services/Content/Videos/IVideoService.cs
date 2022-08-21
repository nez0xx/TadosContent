namespace Content.Domain.Services.Content.Videos
{
    using System.Threading;
    using System.Threading.Tasks;
    using Entities;
    using global::Domain.Abstractions;
    public interface IVideoService : IDomainService
    {
        Task<Video> CreateVideoAsync(
            string title,
            string url,
            CancellationToken cancellationToken = default);
    }
}

