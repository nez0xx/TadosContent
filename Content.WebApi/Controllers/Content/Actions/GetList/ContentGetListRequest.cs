namespace Content.WebApi.Controllers.Content.Actions.GetList
{
    using Infrastructure.Pagination;


    public record ContentGetListRequest
    {
        // Если объект Pagination не указан, то отдаётся весь список
        public Pagination Pagination { get; set; }

        public ContentGetListFilter Filter { get; set; }
    }
}