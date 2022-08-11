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
        protected internal Gallery(string title, string link) : base(ContentType.Gallery, title)
        {
            Link = link;
        }

        public virtual string Link { get; protected set; }
    }
}
