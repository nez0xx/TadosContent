namespace Content.WebApi.Controllers.City.Actions.GetList
{
    using Dto;
    using Infrastructure.Pagination;
    using Api.Requests.Abstractions;


    public record CityGetListResponse(PaginatedList<CityListItemDto> Page) : IResponse;
}