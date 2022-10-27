namespace Content.WebApi.Controllers.Content.Profiles
{
    using AutoMapper;
    using Domain.Entities;
    using Dto;

    public class ContentProfile : Profile
    {
        public ContentProfile()
        {
            CreateMap<Content, ContentListItemDto>();


            CreateMap<Content, ContentDto>()
                .Include<Article, ArticleDto>()
                .Include<Video, VideoDto>()
                .Include<Gallery, GalleryDto>();

            CreateMap<Article, ArticleDto>();
            CreateMap<Video, VideoDto>();
            CreateMap<Gallery, GalleryDto>();
        }
    }
}
