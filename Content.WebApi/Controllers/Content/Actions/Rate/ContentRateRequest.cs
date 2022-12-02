using Api.Requests.Abstractions;

namespace Content.WebApi.Controllers.Content.Actions.Rate
{
    public record ContentRateRequest : IRequest
    {
        public long UserId { get; set; }

        public long ContentId { get; set; }

        public int Digit { get; set; }
    }
}