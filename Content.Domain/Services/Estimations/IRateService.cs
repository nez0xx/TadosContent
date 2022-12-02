namespace Content.Domain.Services.Estimations
{
    using System.Threading;
    using Entities;
    using System.Threading.Tasks;
    using global::Domain.Abstractions;


    public interface IRateService : IDomainService
    {
        void Rate(Content content, User user, int digit, CancellationToken cancellationToken = default);
    }
}