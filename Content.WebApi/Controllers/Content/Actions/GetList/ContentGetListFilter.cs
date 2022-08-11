namespace Content.WebApi.Controllers.Content.Actions.GetList
{
    using Dto;

    public record ContentGetListFilter
    {
        public ContentCategory? Category { get; set; }

        public long? UserId { get; set; }

        // Данное поле должно учитываться в поиске по ссылкам и текстам статей, а не только в названии
        public string Search { get; set; }
    }
}