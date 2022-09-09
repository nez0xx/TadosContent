namespace Content.WebApi.Controllers.Country.Actions.Create
{
    using Api.Requests.Abstractions;
    public record CountryCreateResponse(long Id) : IResponse;
}