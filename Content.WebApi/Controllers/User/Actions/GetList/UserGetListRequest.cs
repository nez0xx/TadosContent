namespace Content.WebApi.Controllers.User.Actions.GetList
{
    using Infrastructure.Pagination;

    public record UserGetListRequest
    {
        // Если объект Pagination не указан, то отдаётся весь список
        public Pagination Pagination { get; set; }
        
        public UserGetListFilter Filter { get; set; }
    }
}