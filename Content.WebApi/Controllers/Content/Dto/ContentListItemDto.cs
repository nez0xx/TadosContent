namespace Content.WebApi.Controllers.Content.Dto
{
    using User.Dto;


    public class ContentListItemDto
    {
        public long Id { get; set; }

        public ContentCategory Type { get; set; }

        public UserListItemDto Creator { get; set; }

        public string Title { get; set; }
        
        public decimal AverageRating { get; set; }
    }
}