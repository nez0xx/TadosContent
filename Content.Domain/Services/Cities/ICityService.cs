namespace Content.Domain.Services.Cities
{
    using System.Threading;
    using System.Threading.Tasks;
    using Entities;
    using global::Domain.Abstractions;
    public interface ICityService : IDomainService
    {
        Task<City> CreateCityAsync(string name, Country country, CancellationToken cancellationToken = default);

        Task UpdateCityAsync(City city, long id, CancellationToken cancellationToken = default);
    }
}

