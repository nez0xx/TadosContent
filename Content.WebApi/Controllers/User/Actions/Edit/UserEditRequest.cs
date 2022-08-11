namespace Content.WebApi.Controllers.User.Actions.Edit
{
    public record UserEditRequest
    {
        public long Id { get; set; }
        
        public long CityId { get; set; }
    }
}