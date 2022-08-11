namespace Content.WebApi.Controllers.Content.Actions.GetList
{
    using Dto;
    using Infrastructure.Pagination;

    public record ContentGetListResponse(PaginatedList<ContentDto> Page);
}