namespace Content.WebApi.Controllers.Content.Actions.Edit
{
    using System;
    using System.Threading.Tasks;
    using Domain.Entities;
    using Domain.Criteria;
    using Domain.Services.Content.Videos;
    using Queries.Abstractions;

    public class VideoEditHierarchicRequestHandler : ContentEditHierarchicRequestHandler<VideoEditHierarchicRequest>
    {
        IAsyncQueryBuilder _asyncQueryBuilder;

        public VideoEditHierarchicRequestHandler(IAsyncQueryBuilder asyncQueryBuilder)
            : base(asyncQueryBuilder)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
        }



        protected override async Task EditContentAsync(
            long id,
            VideoEditHierarchicRequest request)
        {
            Video video = await _asyncQueryBuilder
                .For<Video>()
                .WithAsync(new FindById(id)); 
                
            if (video == null) throw new ArgumentNullException(nameof(id));
             
            if (request.Title != null) video.SetTitle(request.Title);

            if (request.Url != null) video.SetUrl(request.Url);
        }
    }
}
