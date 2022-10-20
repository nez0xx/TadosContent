namespace Content.Domain.Services.Users
{
    using System.Threading;
    using System.Threading.Tasks;
    using Entities;
    using global::Domain.Abstractions;
    public interface IUserService : IDomainService
    {
        Task<User> CreateUserAsync(
            City city, 
            string email,
            CancellationToken cancellationToken = default);

        Task UpdateUserAsync(User user,
            long id,
            CancellationToken cancellationToken = default);
    }
}

