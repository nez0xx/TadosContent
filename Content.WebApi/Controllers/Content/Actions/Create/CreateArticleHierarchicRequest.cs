namespace Content.WebApi.Controllers.Content.Actions.Create
{
    using System.ComponentModel.DataAnnotations;
    using Common.DataAnnotations.Hierarchy;
    using Domain.Enums;

    [Hierarchy(ContentType.Article)]
    public record CreateArticleHierarchicRequest : ContentCreateHierarchicRequestBase
    {
        [Required]
        public string Text { get; init; }
    }
}