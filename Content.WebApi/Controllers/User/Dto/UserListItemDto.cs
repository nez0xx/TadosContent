namespace Content.WebApi.Controllers.User.Dto
{
    public class UserListItemDto
    {
        public long Id { get; set; }

        public string Email { get; set; }

        // Свойство должно содержать значение вида "Страна, Город"
        public string CityFullName { get; set; }
    }
}