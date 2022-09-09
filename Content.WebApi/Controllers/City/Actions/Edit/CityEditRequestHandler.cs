namespace Content.WebApi.Controllers.City.Actions.Edit 
{
    using System;
    using System.Threading.Tasks;
    using Api.Requests.Abstractions;
    using Domain.Criteria;
    using Domain.Entities;
    using Domain.Services.Cities;
    using Queries.Abstractions;
    public class CityEditRequestHandler : IAsyncRequestHandler<CityEditRequest>
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;
        private readonly ICityService _cityService;



        public CityEditRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, ICityService cityService)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
            _cityService = cityService ?? throw new ArgumentNullException(nameof(cityService));
        }



        public async Task ExecuteAsync(CityEditRequest request)
        {
            City city = await _asyncQueryBuilder
                .For<City>()
                .WithAsync(new FindById(request.Id));

             await _cityService.UpdateCityAsync(city);

        }
    }
}