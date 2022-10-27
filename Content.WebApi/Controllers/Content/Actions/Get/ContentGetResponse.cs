namespace Content.WebApi.Controllers.Content.Actions.Get
{
    using Dto;
    using Api.Requests.Abstractions;
    public record ContentGetResponse(ContentDto Content) : IResponse;
}