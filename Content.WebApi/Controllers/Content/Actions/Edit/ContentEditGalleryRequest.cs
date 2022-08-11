namespace Content.WebApi.Controllers.Content.Actions.Edit
{
    using System.Collections.Generic;

    public record ContentEditGalleryRequest : ContentEditRequestBase
    {
        public string CoverUrl { get; set; }

        public List<string> ImagesUrls { get; set; }
    }
}