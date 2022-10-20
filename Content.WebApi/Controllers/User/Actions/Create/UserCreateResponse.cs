namespace Content.WebApi.Controllers.User.Actions.Create
{
    using Api.Requests.Abstractions;
    public record UserCreateResponse(long Id) : IResponse;
}