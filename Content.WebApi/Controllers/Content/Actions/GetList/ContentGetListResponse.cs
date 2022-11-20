namespace Content.WebApi.Controllers.Content.Actions.GetList
{
    using Dto;
    using Infrastructure.Pagination;
    using Api.Requests.Abstractions;

    public record ContentGetListResponse(PaginatedList<ContentListItemDto> Page) : IResponse;
}