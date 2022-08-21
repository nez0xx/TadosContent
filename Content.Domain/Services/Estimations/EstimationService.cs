namespace Content.Domain.Services.Estimations
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Commands.Contexts;
    using Entities;
    using global::Commands.Abstractions;
    using ValueObjects;

    public class EstimationService : IEstimationService
    {
        private readonly IAsyncCommandBuilder _commandBuilder;


        public EstimationService(IAsyncCommandBuilder commandBuilder)
        {
            _commandBuilder = commandBuilder ?? throw new ArgumentNullException(nameof(commandBuilder));
        }


        public async Task EstimateAsync(Content content, User user, int digit, CancellationToken cancellationToken = default)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            Estimation estimation = content.Estimate(user, digit);

            await _commandBuilder.UpdateAsync(estimation, cancellationToken);
            await _commandBuilder.ExecuteAsync(new CreateEstimationCommandContext(user, estimation), cancellationToken);
        }
    }
}