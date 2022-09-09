namespace Content.Domain.Commands.Contexts
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using global::Commands.Abstractions;
    using global::Domain.Abstractions;


    public class UpdateObjectWithIdCommandContext<THasId> : ICommandContext
        where THasId : class, IHasId, new()
    {
        public UpdateObjectWithIdCommandContext(THasId objectWithId, long id)
        {
            ObjectWithId = objectWithId ?? throw new ArgumentNullException(nameof(objectWithId));
            this.Id = id;
        }


        public THasId ObjectWithId { get; }
        public long Id { get;  }
    }

    public static class UpdateObjectWithIdCommandContextExtensions
    {
        public static Task UpdateAsync<THasId>(
            this IAsyncCommandBuilder commandBuilder,
            THasId objectWithId,
            long id,
            CancellationToken cancellationToken = default) where THasId : class, IHasId, new()
        {
            return commandBuilder.ExecuteAsync(
                new UpdateObjectWithIdCommandContext<THasId>(objectWithId, id),
                cancellationToken);
        }
    }
}