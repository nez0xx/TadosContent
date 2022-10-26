namespace Content.WebApi.Controllers.Content.Actions.Create
{
    using Api.Requests.Hierarchic.Abstractions;
    public record ContentCreateHierarchicResponse(long Id) : IHierarchicResponse;
}