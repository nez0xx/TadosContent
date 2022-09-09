namespace Content.WebApi.Controllers.City.Actions.Create
{
    using Api.Requests.Abstractions;
    public record CityCreateResponse(long Id) : IResponse;
}