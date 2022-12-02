using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstractions;

namespace Content.Domain.ValueObjects
{
    public class Link : IValueObjectWithId
    {
        [Obsolete("Only for reflection", true)]
        public Link()
        {
        }

        protected internal Link(string link)
        {
            Value = link;
        }

        public virtual long Id { get; protected set; }
        public virtual string Value { get; protected set; }

    }
}
