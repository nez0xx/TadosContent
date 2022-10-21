using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstractions;
using Content.Domain.Entities;

namespace Content.Domain.ValueObjects
{
    public class Estimation : IValueObjectWithId
    {
        [Obsolete("Only for reflection", true)]
        public Estimation()
        {
        }

        protected internal Estimation(User user, int digit)
        {
            Digit = digit;
            User = user;
        }

        public virtual long Id { get; protected set; }

        public virtual int Digit { get; protected set; }

        public virtual User User { get; protected set; }

    }
        
}
