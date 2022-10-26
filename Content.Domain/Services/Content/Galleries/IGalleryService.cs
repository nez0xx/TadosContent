namespace Content.Domain.Services.Content.Galleries
{
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Entities;
    using global::Domain.Abstractions;

    public interface IGalleryService : IDomainService
    {
        Task<Gallery> CreateGalleryAsync(
            string title, 
            List<string> imagesUrls, 
            string coverUrl,
            User creator,
            CancellationToken cancellationToken = default);
        /*
        Task UpdateGalleryAsync(Gallery gallery, long id,
            CancellationToken cancellationToken = default);*/
    }
}

