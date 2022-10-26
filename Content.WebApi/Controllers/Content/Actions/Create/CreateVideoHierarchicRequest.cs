namespace Content.WebApi.Controllers.Content.Actions.Create
{
    using System.ComponentModel.DataAnnotations;
    using Common.DataAnnotations.Hierarchy;
    using Domain.Enums;

    [Hierarchy(ContentType.Video)]
    public record CreateVideoHierarchicRequest : ContentCreateHierarchicRequestBase
    {
        [Required]
        public string Url { get; set; }
    }
}