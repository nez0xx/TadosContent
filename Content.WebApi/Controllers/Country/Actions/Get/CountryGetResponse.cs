namespace Content.WebApi.Controllers.Country.Actions.Get
{
    using Dto;
    using Api.Requests.Abstractions;

    public record CountryGetResponse(CountryDto Country) : IResponse;
}