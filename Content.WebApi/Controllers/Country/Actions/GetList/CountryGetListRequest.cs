namespace Content.WebApi.Controllers.Country.Actions.GetList
{
    using Infrastructure.Pagination;
    using Api.Requests.Abstractions;

    public record CountryGetListRequest : IRequest<CountryGetListResponse>  
    {
        // Если объект Pagination не указан, то отдаётся весь список
        public Pagination Pagination { get; set; }

        public CountryGetListFilter Filter { get; set; }
    }
}