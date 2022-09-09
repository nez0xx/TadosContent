namespace Content.WebApi.Controllers.City.Actions.Get
{
    using System;
    using System.Threading.Tasks;
    using Api.Requests.Abstractions;
    using AutoMapper;
    using Domain.Criteria;
    using Domain.Entities;
    using Dto;
    using Queries.Abstractions;

    public class CityGetRequestHandler : IAsyncRequestHandler<CityGetRequest, CityGetResponse>
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;
        private readonly IMapper _mapper;



        public CityGetRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, IMapper mapper)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }



        public async Task<CityGetResponse> ExecuteAsync(CityGetRequest request)
        {
            City city = await _asyncQueryBuilder
                .For<City>()
                .WithAsync(new FindById(request.Id));

            return new CityGetResponse(_mapper.Map<CityDto>(city));
        }
    }
}
