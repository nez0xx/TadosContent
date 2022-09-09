namespace Content.WebApi.Controllers.City.Actions.Get
{
    using Api.Requests.Abstractions;

    public record CityGetRequest : IRequest<CityGetResponse>
    {
        public long Id { get; set; }
    }
}