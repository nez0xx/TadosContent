namespace Content.WebApi.Controllers.Content.Actions.Create
{ 
    using System;
    using System.Threading.Tasks;
    using Domain.Entities;
    using Domain.Services.Content.Videos;
    using Queries.Abstractions;

    public class CreateVideoHierarchicRequestHandler : ContentCreateHierarchicRequestHandler<CreateVideoHierarchicRequest>
    {
        private readonly IVideoService _videoService;



        public CreateVideoHierarchicRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, IVideoService videoService)
            : base(asyncQueryBuilder)
        {
            _videoService = videoService ?? throw new ArgumentNullException(nameof(videoService));
        }



        protected override async Task<Content> CreateContentAsync(
            string title,
            User user,
            CreateVideoHierarchicRequest request)
        {
            Video video = await _videoService.CreateVideoAsync(
                                                title: title,
                                                url: request.Url,
                                                creator: user);

            return video;
        }
    }
}
