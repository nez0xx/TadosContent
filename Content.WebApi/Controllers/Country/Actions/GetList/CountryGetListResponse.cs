namespace Content.WebApi.Controllers.Country.Actions.GetList
{
    using Dto;
    using Infrastructure.Pagination;


    public record CountryGetListResponse(PaginatedList<CountryListItemDto> Page);
}