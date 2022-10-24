namespace Content.WebApi.Controllers.Country.Actions.GetList
{
    using Dto;
    using Infrastructure.Pagination;
    using Api.Requests.Abstractions;

    public record CountryGetListResponse(PaginatedList<CountryListItemDto> Page) : IResponse;
}