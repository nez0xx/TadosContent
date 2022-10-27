namespace Content.WebApi.Controllers.Content.Actions.Edit
{
    using Common.DataAnnotations.Hierarchy;
    using Domain.Enums;

    [Hierarchy(ContentType.Video)]
    public record VideoEditHierarchicRequest : ContentEditHierarchicRequestBase
    {
        public string Url { get; set; }
    }
}