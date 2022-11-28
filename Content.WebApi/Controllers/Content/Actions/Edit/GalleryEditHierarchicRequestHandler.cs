namespace Content.WebApi.Controllers.Content.Actions.Edit
{
    using System;
    using System.Threading.Tasks;
    using Domain.Entities;
    using Domain.Criteria;
    using Domain.Services.Content.Videos;
    using Queries.Abstractions;

    public class GalleryEditHierarchicRequestHandler : ContentEditHierarchicRequestHandler<GalleryEditHierarchicRequest>
    {
        IAsyncQueryBuilder _asyncQueryBuilder;


        public GalleryEditHierarchicRequestHandler(IAsyncQueryBuilder asyncQueryBuilder)
            : base(asyncQueryBuilder)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
        }



        protected override async Task EditContentAsync(
            long id,
            GalleryEditHierarchicRequest request)
        {
            Gallery gallery = await _asyncQueryBuilder
                .For<Gallery>()
                .WithAsync(new FindById(id));

            if (gallery == null) throw new Exception(nameof(id));
             
            if (request.Title != null) gallery.SetTitle(request.Title);

            if (request.CoverUrl != null) gallery.SetCoverUrl(request.CoverUrl);



        }
    }
}
