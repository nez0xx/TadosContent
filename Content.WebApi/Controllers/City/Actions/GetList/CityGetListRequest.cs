namespace Content.WebApi.Controllers.City.Actions.GetList
{
    using Api.Requests.Abstractions;
    using Infrastructure.Pagination;


    public record CityGetListRequest : IRequest<CityGetListResponse>
    {
        // Если объект Pagination не указан, то отдаётся весь список
        public Pagination Pagination { get; set; }
        
        public CityGetListFilter Filter { get; set; }
    }
}