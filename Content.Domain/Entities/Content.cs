using System;
using Content.Domain.Enums;
using global::Domain.Abstractions;
namespace Content.Domain.Entities
{
    public class Content : IEntity
    {
        [Obsolete("Only for reflection", true)]
        public Content()
        {
        }

        protected Content(ContentType type, string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(title));

            Type = type;
            Title = title;
        }

        public virtual long Id { get; protected set; }

        public virtual ContentType Type { get; protected set; }
        
        public virtual String Title { get; protected set; }


    }
}
