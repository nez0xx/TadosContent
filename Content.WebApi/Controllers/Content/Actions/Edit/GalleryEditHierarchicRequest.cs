namespace Content.WebApi.Controllers.Content.Actions.Edit
{
    using System.Collections.Generic;
    using Common.DataAnnotations.Hierarchy;
    using Domain.Enums;

    [Hierarchy(ContentType.Gallery)]
    public record GalleryEditHierarchicRequest : ContentEditHierarchicRequestBase
    {
        public string CoverUrl { get; set; }
        public List<string> ImagesUrls { get; set; }
    }
}