namespace Content.WebApi.Controllers.User.Actions.Create
{
    public record UserCreateRequest
    {
        public string Email { get; set; }

        public long CityId { get; set; }
    }
}