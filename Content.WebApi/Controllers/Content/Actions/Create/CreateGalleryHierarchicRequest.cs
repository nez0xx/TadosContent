namespace Content.WebApi.Controllers.Content.Actions.Create
{
    using System.ComponentModel.DataAnnotations;
    using Common.DataAnnotations.Hierarchy;
    using System.Collections.Generic;
    using Domain.Enums;

    [Hierarchy(ContentType.Gallery)]
    public record CreateGalleryHierarchicRequest : ContentCreateHierarchicRequestBase
    {
        [Required]
        public string CoverUrl { get; set; }

        [Required]
        public List<string> ImagesUrls { get; set; }
    }
}