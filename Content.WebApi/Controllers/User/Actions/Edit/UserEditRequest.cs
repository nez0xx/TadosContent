namespace Content.WebApi.Controllers.User.Actions.Edit
{
    using Api.Requests.Abstractions;
    public record UserEditRequest : IRequest
    {
        public long Id { get; set; }
        
        public long CityId { get; set; }
    }
}