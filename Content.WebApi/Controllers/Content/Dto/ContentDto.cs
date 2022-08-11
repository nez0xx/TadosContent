namespace Content.WebApi.Controllers.Content.Dto
{
    using User.Dto;

    public abstract class ContentDto
    {
        public long Id { get; set; }

        public ContentCategory Category { get; set; }

        public UserDto Creator { get; set; }

        public string Name { get; set; }
        
        public decimal AverageRating { get; set; }
    }
}