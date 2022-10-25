namespace Content.WebApi.Controllers.User.Actions.GetList
{
    using Dto;
    using Infrastructure.Pagination;
    using Api.Requests.Abstractions;
    public record UserGetListResponse(PaginatedList<UserListItemDto> Page) : IResponse;
}