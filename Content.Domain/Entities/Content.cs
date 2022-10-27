using System;
using System.Linq;
using Content.Domain.Enums;
using System.Collections.Generic;
using global::Domain.Abstractions;
using Content.Domain.ValueObjects;

namespace Content.Domain.Entities
{
    public class Content : IEntity
    {
        private readonly ICollection<Estimation> _estimations = new HashSet<Estimation>();

        //[Obsolete("Only for reflection", true)]
        public Content()
        {
        }
        
        protected Content(ContentType type, string title, User user)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(title));

            Type = type;
            Title = title;
            Creator = user;
        }

        public virtual long Id { get; protected set; }
            
        public virtual User Creator { get; protected set; }

        public virtual ContentType Type { get; protected set; }
        
        public virtual String Title { get; protected set; }

        public virtual IEnumerable<Estimation> Estimations => _estimations;

        protected internal virtual Estimation Estimate(User user, int digit)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            if (digit <= 0 || digit > 5)
                throw new ArgumentOutOfRangeException(nameof(digit));

            Estimation estimation = new Estimation(user, digit);

            _estimations.Add(estimation);

            return estimation;
        }

        public virtual void SetTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(title));
            Title = title;
        }

    }
}
