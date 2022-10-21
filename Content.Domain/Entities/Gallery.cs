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
        private readonly ICollection<string> _imagesUrls = new HashSet<string>();

        [Obsolete("Only for reflection", true)]
        public Gallery()
        {
        }
        protected internal Gallery(string title, List<string> imagesUrls, string link) : base(ContentType.Gallery, title)
        {   
            _imagesUrls = imagesUrls;
            Link = link;
        }

        public virtual IEnumerable<string> ImagesUrls => _imagesUrls;
        public virtual string Link { get; protected set; }
    }
}
