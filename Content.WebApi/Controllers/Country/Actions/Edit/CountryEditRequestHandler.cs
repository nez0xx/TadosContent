namespace Content.WebApi.Controllers.Country.Actions.Edit 
{
    using System;
    using System.Threading.Tasks;
    using Api.Requests.Abstractions;
    using Domain.Criteria;
    using Domain.Entities;
    using Domain.Services.Countries;
    using Queries.Abstractions;
    public class CountryEditRequestHandler : IAsyncRequestHandler<CountryEditRequest>
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;
        private readonly ICountryService _countryService;



        public CountryEditRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, ICountryService countryService)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
            _countryService = countryService ?? throw new ArgumentNullException(nameof(countryService));
        }



        public async Task ExecuteAsync(CountryEditRequest request)
        {
             Country country = await _asyncQueryBuilder
                .For<Country>()
                .WithAsync(new FindById(request.Id));

             await _countryService.UpdateCountryAsync(country, request.Id);

        }
    }
}