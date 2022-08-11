namespace Content.WebApi.Controllers.Content.Actions.Edit
{
    public record ContentEditArticleRequest : ContentEditRequestBase
    {
        public string Text { get; set; }
    }
}