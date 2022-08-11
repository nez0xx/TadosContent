namespace Content.WebApi.Controllers.Content.Dto
{
    using User.Dto;


    public class ContentListItemDto
    {
        public long Id { get; set; }

        public ContentCategory Category { get; set; }

        public UserListItemDto Creator { get; set; }

        public string Name { get; set; }
        
        public decimal AverageRating { get; set; }
    }
}