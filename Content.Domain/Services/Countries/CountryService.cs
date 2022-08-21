namespace Content.Domain.Services.Countries
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Commands.Contexts;
    using Entities;
    using Enums;
    using global::Commands.Abstractions;
    using Queries.Abstractions;

    public class CountryService : ICountryService
    {
        private readonly IAsyncCommandBuilder _asyncCommandBuilder;

        public CountryService(IAsyncQueryBuilder asyncQueryBuilder, IAsyncCommandBuilder asyncCommandBuilder) 
        {
            _asyncCommandBuilder = asyncCommandBuilder ?? throw new ArgumentNullException(nameof(asyncCommandBuilder));
        }


        public async Task<Country> CreateCountryAsync(string name, CancellationToken cancellationToken = default)
        {


            Country country = new Country(name);

            await _asyncCommandBuilder.CreateAsync(country, cancellationToken);

            return country;
        }
    }
}