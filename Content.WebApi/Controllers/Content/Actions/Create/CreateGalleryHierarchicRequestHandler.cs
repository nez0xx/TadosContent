namespace Content.WebApi.Controllers.Content.Actions.Create
{
    using System;
    using System.Threading.Tasks;
    using Domain.Entities;
    using Domain.Services.Content.Galleries;
    using Queries.Abstractions;

    public class CreateGalleryHierarchicRequestHandler : ContentCreateHierarchicRequestHandler<CreateGalleryHierarchicRequest>
    {
        private readonly IGalleryService _galleryService;



        public CreateGalleryHierarchicRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, IGalleryService galleryService)
            : base(asyncQueryBuilder)
        {
            _galleryService = galleryService ?? throw new ArgumentNullException(nameof(galleryService));
        }



        protected override async Task<Content> CreateContentAsync(
            string title,
            User user,
            CreateGalleryHierarchicRequest request)
        {
            Gallery gallery = await _galleryService.CreateGalleryAsync(
                                                title: title,
                                                coverUrl: request.CoverUrl,
                                                imagesUrls: request.ImagesUrls,
                                                creator: user);

            return gallery;
        }
    }
}
