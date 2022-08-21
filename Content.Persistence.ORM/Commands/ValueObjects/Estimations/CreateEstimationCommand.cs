namespace Content.Persistence.ORM.Commands.ValueObjects.Estimations
{
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.Commands.Contexts;
    using global::Commands.Abstractions;


    public class CreateEstiomationCommand : IAsyncCommand<CreateEstimationCommandContext>
    {
        public Task ExecuteAsync(
            CreateEstimationCommandContext commandContext,
            CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }
    }
}