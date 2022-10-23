 namespace Content.WebApi.Controllers.Country.Actions.Create
{
    using AutoMapper;
    using System;
    using System.Threading.Tasks;
    using Api.Requests.Abstractions;
    using Domain.Criteria;
    using Domain.Entities;
    using Domain.Services.Countries;
    using Queries.Abstractions;
    public class CountryCreateRequestHandler : IAsyncRequestHandler<CountryCreateRequest, CountryCreateResponse>
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;
        private readonly ICountryService _countryService;



        public CountryCreateRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, ICountryService countryService)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
            _countryService = countryService ?? throw new ArgumentNullException(nameof(countryService));
        }



        public async Task<CountryCreateResponse> ExecuteAsync(CountryCreateRequest request)
        {
            Country country = await _countryService.CreateCountryAsync(
                name: request.Name
            );

            return new CountryCreateResponse(country.Id);
        }
    }
}