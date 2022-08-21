using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Content.Domain.Enums;

namespace Content.Domain.Entities
{
    public class Gallery : Content
    {
        [Obsolete("Only for reflection", true)]
        public Gallery()
        {
        }
        protected internal Gallery(string title, List<string> imagesUrls, string link) : base(ContentType.Gallery, title)
        {   
            ImagesUrls = imagesUrls;
            Link = link;
        }

        public List<string> ImagesUrls { get; set; }
        public virtual string Link { get; protected set; }
    }
}
