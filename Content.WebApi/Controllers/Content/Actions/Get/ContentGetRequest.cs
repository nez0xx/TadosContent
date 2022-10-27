namespace Content.WebApi.Controllers.Content.Actions.Get
{
    using Api.Requests.Abstractions;
    public record ContentGetRequest : IRequest<ContentGetResponse>
    {
        public long Id { get; set; }
    }
}