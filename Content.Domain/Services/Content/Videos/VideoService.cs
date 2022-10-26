namespace Content.Domain.Services.Content.Videos
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Commands.Contexts;
    using Entities;
    using Enums;
    using global::Commands.Abstractions;
    using Queries.Abstractions;

    public class VideoService : IVideoService
    {
        private readonly IAsyncCommandBuilder _asyncCommandBuilder;

        public VideoService(IAsyncQueryBuilder asyncQueryBuilder, IAsyncCommandBuilder asyncCommandBuilder) 
        {
            _asyncCommandBuilder = asyncCommandBuilder ?? throw new ArgumentNullException(nameof(asyncCommandBuilder));
        }


        public async Task<Video> CreateVideoAsync(string title, string url, User creator, CancellationToken cancellationToken = default)
        {


            Video video = new Video(title, url, creator);

            await _asyncCommandBuilder.CreateAsync(video, cancellationToken);

            return video;
        }

    }
}