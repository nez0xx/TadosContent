namespace Content.WebApi.Controllers.City.Actions.Edit
{
    public record CityEditRequest
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public long CountryId { get; set; }
    }
}