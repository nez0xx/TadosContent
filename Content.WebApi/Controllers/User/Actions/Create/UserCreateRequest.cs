namespace Content.WebApi.Controllers.User.Actions.Create
{
    using Api.Requests.Abstractions;
    public record UserCreateRequest : IRequest<UserCreateResponse>
    {
        
        public string Email { get; set; }

        public long CityId { get; set; }
    }
}