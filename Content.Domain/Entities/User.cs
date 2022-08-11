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
        protected internal User(City city, string email)
        {
            City = city;  
            Email = email;
        }
        public virtual long Id { get; protected set; }

        public City City { get; protected set; }

        public string Email { get; protected set; }
    }
}
