namespace Content.WebApi.Controllers.Content.Actions.Create
{
    using System.Collections.Generic;


    public record ContentCreateGalleryRequest : ContentCreateRequestBase
    {
        public string CoverUrl { get; set; }

        public List<string> ImagesUrls { get; set; }
    }
}