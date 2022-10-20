namespace Content.WebApi.Controllers.Country.Actions.Get
{
    using Api.Requests.Abstractions;
    public record CountryGetRequest : IRequest<CountryGetResponse>
    {
        public long Id { get; set; }
    }
}