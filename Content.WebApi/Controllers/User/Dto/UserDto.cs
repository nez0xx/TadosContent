namespace Content.WebApi.Controllers.User.Dto
{
    using City.Dto;


    public class UserDto
    {
        public long Id { get; set; }

        public string Email { get; set; }

        public CityDto City { get; set; }
    }
}