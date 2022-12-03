namespace Content.WebApi.Controllers.Content.Dto
{
    using User.Dto;

    public abstract class ContentDto
    {
        public long Id { get; set; }

        public ContentCategory Type { get; set; }

        public UserDto Creator { get; set; }

        public string Title { get; set; }
        
        public float AverageRating { get; set; }
    }
}