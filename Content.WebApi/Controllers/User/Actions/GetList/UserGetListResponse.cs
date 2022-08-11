namespace Content.WebApi.Controllers.User.Actions.GetList
{
    using Dto;
    using Infrastructure.Pagination;

    public record UserGetListResponse(PaginatedList<UserListItemDto> Page);
}