namespace Content.WebApi.Controllers.City.Actions.Create
{
    using System;
    using System.Threading.Tasks;
    using Api.Requests.Abstractions;
    using Domain.Criteria;
    using Domain.Entities;
    using Domain.Services.Cities;
    using Queries.Abstractions;
    public class CityCreateRequestHandler : IAsyncRequestHandler<CityCreateRequest, CityCreateResponse>
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;
        private readonly ICityService _cityService;



        public CityCreateRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, ICityService cityService)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
            _cityService = cityService ?? throw new ArgumentNullException(nameof(cityService));
        }



        public async Task<CityCreateResponse> ExecuteAsync(CityCreateRequest request)
        {
            Country country = await _asyncQueryBuilder
                .For<Country>()
                .WithAsync(new FindById(request.CountryId));

            City city = await _cityService.CreateCityAsync(
                name: request.Name,
                country: country
            );

            return new CityCreateResponse(city.Id);
        }
    }
}