namespace Content.Domain.Commands.Contexts
{
    using System;
    using Entities;
    using global::Commands.Abstractions;
    using ValueObjects;


    public class CreateEstimationCommandContext : ICommandContext
    {
        public CreateEstimationCommandContext(User user, Estimation estimation)
        {
            User = user ?? throw new ArgumentNullException(nameof(user));
            Estimation = estimation ?? throw new ArgumentNullException(nameof(estimation));
        }


        public User User { get; }

        public Estimation Estimation { get; }
    }
}