namespace Content.WebApi.Controllers.City.Actions.GetList
{
    public record CityGetListFilter
    {
        public long? CountryId { get; set; }
        
        public string Search { get; set; }
    }
}