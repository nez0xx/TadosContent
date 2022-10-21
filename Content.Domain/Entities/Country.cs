using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstractions;

namespace Content.Domain.Entities
{
    public class Country : IEntity
    {
        [Obsolete("Only for reflection", true)]
        public Country()
        {
        }
        protected internal Country(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(name));
        }

        public virtual long Id { get; protected set; }

        public virtual string Name { get; protected set; }
    }
}
