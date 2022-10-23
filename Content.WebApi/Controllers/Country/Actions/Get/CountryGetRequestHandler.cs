namespace Content.WebApi.Controllers.Country.Actions.Get
{
    using System;
    using System.Threading.Tasks;
    using Api.Requests.Abstractions;
    using AutoMapper;
    using Domain.Criteria;
    using Domain.Entities;
    using Dto;
    using Queries.Abstractions;

    public class CountryGetRequestHandler : IAsyncRequestHandler<CountryGetRequest, CountryGetResponse>
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;



        public CountryGetRequestHandler(IAsyncQueryBuilder asyncQueryBuilder)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
        }



        public async Task<CountryGetResponse> ExecuteAsync(CountryGetRequest request)
        {
            Country country = await _asyncQueryBuilder
                .For<Country>()
                .WithAsync(new FindById(request.Id));

            return new CountryGetResponse(country);
        }
    }
}
