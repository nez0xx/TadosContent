using System;
using System.Collections.Generic;
using Content.Domain.Enums;
using Content.Domain.ValueObjects;


namespace Content.Domain.Entities
{
    public class Gallery : Content
    {
        private readonly ICollection<Link> _imagesUrls = new HashSet<Link>();

        [Obsolete("Only for reflection", true)]
        public Gallery()
        {
        }
        
        protected internal Gallery(string title, List<string> imagesUrls, string coverUrl, User creator) : base(ContentType.Gallery, title, creator)
        {   
            AddImagesUrls(imagesUrls);
            CoverUrl = coverUrl;
        }

        public virtual IEnumerable<Link> ImagesUrls => _imagesUrls;
        public virtual string CoverUrl { get; protected set; }

        public virtual void SetCoverUrl(string coverUrl)
        {
            if (string.IsNullOrWhiteSpace(coverUrl))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(coverUrl));
            CoverUrl = coverUrl;
        }

        protected internal virtual void AddImagesUrls(List<string> imagesUrls)
        {
            if (imagesUrls == null)
                throw new ArgumentException("Value cannot be null.", nameof(imagesUrls));
            foreach (string url in imagesUrls)
            {
                Link link = new Link(url);
                _imagesUrls.Add(link);
            }
            
        }
    }
}
