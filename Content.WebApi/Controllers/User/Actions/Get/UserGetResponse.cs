namespace Content.WebApi.Controllers.User.Actions.Get
{
    using Dto;
    using Api.Requests.Abstractions;
    public record UserGetResponse(UserDto User) : IResponse;
}