namespace Content.WebApi.Controllers.Content.Actions.Rate
{
    public record ContentRateRequest
    {
        public long UserId { get; set; }

        public long ContentId { get; set; }
    }
}