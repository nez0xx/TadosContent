namespace Content.Domain.Services.Estimations
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Commands.Contexts;
    using Entities;
    using global::Commands.Abstractions;
    using ValueObjects;

    public class RateService : IRateService
    {
        private readonly IAsyncCommandBuilder _asyncCommandBuilder;


        public RateService(IAsyncCommandBuilder commandBuilder)
        {
            _asyncCommandBuilder = commandBuilder ?? throw new ArgumentNullException(nameof(commandBuilder));
        }


        public void Rate(Content content, User user, int digit, CancellationToken cancellationToken = default)
        {
            
            
                if (content == null)
                    throw new ArgumentNullException(nameof(content));

                if (user == null)
                    throw new ArgumentNullException(nameof(user));

                if (digit < 1 || digit > 5)
                 {
                    throw new ArgumentOutOfRangeException(nameof(digit));
                 }

                content.Rate(user, digit);
            
        }
    }
}