namespace Content.WebApi.Controllers.City.Actions.Edit
{
    using Api.Requests.Abstractions;
    public record CityEditRequest : IRequest
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public long CountryId { get; set; }
    }
}