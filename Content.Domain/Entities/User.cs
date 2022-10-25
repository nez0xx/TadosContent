using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstractions;

namespace Content.Domain.Entities
{
    public class User : IEntity
    {

        [Obsolete("Only for reflection", true)]
        public User()
        {
        }

        protected internal User(City city, string email)
        {
            City = city;  
            Email = email;
        }
        public virtual long Id { get; protected set; }

        public virtual City City { get; protected set; }

        public virtual string Email { get; protected set; }

        public virtual void SetCity(City city)
        {
            City = city;
        }
    }
}
