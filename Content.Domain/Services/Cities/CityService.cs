namespace Content.Domain.Services.Cities
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Commands.Contexts;
    using Entities;
    using Enums;
    using global::Commands.Abstractions;
    using Queries.Abstractions;

    public class CityService : ICityService
    {
        private readonly IAsyncCommandBuilder _asyncCommandBuilder;

        public CityService(IAsyncQueryBuilder asyncQueryBuilder, IAsyncCommandBuilder asyncCommandBuilder) 
        {
            _asyncCommandBuilder = asyncCommandBuilder ?? throw new ArgumentNullException(nameof(asyncCommandBuilder));
        }


        public async Task<City> CreateCityAsync(string name, Country country, CancellationToken cancellationToken = default)
        {


            City city = new City(name, country);

            await _asyncCommandBuilder.CreateAsync(city, cancellationToken);

            return city;
        }
    }
}