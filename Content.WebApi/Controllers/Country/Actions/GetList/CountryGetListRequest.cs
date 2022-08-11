namespace Content.WebApi.Controllers.Country.Actions.GetList
{
    using Infrastructure.Pagination;


    public record CountryGetListRequest
    {
        // Если объект Pagination не указан, то отдаётся весь список
        public Pagination Pagination { get; set; }

        public CountryGetListFilter Filter { get; set; }
    }
}