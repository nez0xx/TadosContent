namespace Content.WebApi.Controllers.Content.Actions.Create
{
    public record ContentCreateVideoRequest : ContentCreateRequestBase
    {
        public string Url { get; set; }
    }
}