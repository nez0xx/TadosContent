namespace Content.WebApi.Controllers.User.Actions.Get
{
    using Api.Requests.Abstractions;
    public record UserGetRequest : IRequest<UserGetResponse>
    {
        public long Id { get; set; }
    }
}