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
        
        protected internal Gallery(string title, List<string> imagesUrls, string coverUrl, User creator) : base(ContentType.Gallery, title, creator)
        {   
            _imagesUrls = imagesUrls;
            CoverUrl = coverUrl;
        }

        public virtual IEnumerable<string> ImagesUrls => _imagesUrls;
        public virtual string CoverUrl { get; protected set; }

        public virtual void SetCoverUrl(string coverUrl)
        {
            if (string.IsNullOrWhiteSpace(coverUrl))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(coverUrl));
            CoverUrl = coverUrl;
        }

        public virtual void SetImagesUrls(List<string> imagesUrls)
        {
            if (imagesUrls == null)
                throw new ArgumentException("Value cannot be null.", nameof(imagesUrls));
            //_imagesUrls = imagesUrls;
        }
    }
}
