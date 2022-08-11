namespace Content.WebApi.Controllers.City.Dto
{
    using Country.Dto;


    public class CityDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public CountryDto CountryDto { get; set; }
    }
}