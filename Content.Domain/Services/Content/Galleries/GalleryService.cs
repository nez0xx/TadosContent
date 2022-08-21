namespace Content.Domain.Services.Content.Galleries
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Commands.Contexts;
    using Entities;
    using global::Commands.Abstractions;
    using Queries.Abstractions;

    public class GalleryService : IGalleryService
    {
        private readonly IAsyncCommandBuilder _asyncCommandBuilder;

        public GalleryService(IAsyncQueryBuilder asyncQueryBuilder, IAsyncCommandBuilder asyncCommandBuilder) 
        {
            _asyncCommandBuilder = asyncCommandBuilder ?? throw new ArgumentNullException(nameof(asyncCommandBuilder));
        }


        public async Task<Gallery> CreateGalleryAsync(string title, List<string> imagesUrls, string link, CancellationToken cancellationToken = default)
        {


            Gallery gallery = new Gallery(title, imagesUrls, link);

            await _asyncCommandBuilder.CreateAsync(gallery, cancellationToken);

            return gallery;
        }
    }
}