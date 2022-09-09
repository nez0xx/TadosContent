namespace Content.WebApi.Controllers.City.Actions.Get
{
    using Dto;
    using Api.Requests.Abstractions;

    public record CityGetResponse(CityDto City) : IResponse;
}