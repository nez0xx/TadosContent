namespace Content.WebApi.Controllers.Content.Actions.Edit
{
    using Common.DataAnnotations.Hierarchy;
    using Domain.Enums;

    [Hierarchy(ContentType.Article)]
    public record ArticleEditHierarchicRequest : ContentEditHierarchicRequestBase
    {
        public string Text { get; set; }
    }
}