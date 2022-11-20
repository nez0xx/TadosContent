namespace Content.WebApi.Controllers.Content.Actions.GetList
{
    using Dto;
    using Domain.Enums;
    public record ContentGetListFilter
    {
        public ContentType? Type { get; set; }

        public long? UserId { get; set; }

        // Данное поле должно учитываться в поиске по ссылкам и текстам статей, а не только в названии
        public string Search { get; set; }
    }
}