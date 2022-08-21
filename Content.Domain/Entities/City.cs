using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstractions;

namespace Content.Domain.Entities
{
    public class City : IEntity
    {
        [Obsolete("Only for reflection", true)]
        public City()
        {
        }
        protected internal City(string name, Country country)
        {
            if (country == null)
                throw new ArgumentNullException(nameof(country));
            
            Name = name;
            Country = country;
        }

        public virtual long Id { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual Country Country { get; protected set; }
    }
}
