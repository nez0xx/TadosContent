namespace Content.WebApi.Controllers.Country.Actions.Create
{
    using Api.Requests.Abstractions;
    public record CountryCreateRequest : IRequest<CountryCreateResponse>
    {
        public string Name { get; set; }
    }
}