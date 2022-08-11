namespace Content.WebApi.Controllers.City.Actions.Create
{
    public record CityCreateRequest
    {
        public string Name { get; set; }

        public long CountryId { get; set; }
    }
}