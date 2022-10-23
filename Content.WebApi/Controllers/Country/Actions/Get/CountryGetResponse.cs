namespace Content.WebApi.Controllers.Country.Actions.Get
{
    using Domain.Entities;
    using Api.Requests.Abstractions;

    public record CountryGetResponse(Country Country) : IResponse;
}