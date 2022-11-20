namespace Content.WebApi.Controllers.City.Actions.GetList
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Api.Requests.Abstractions;
    using AutoMapper;
    using Domain.Criteria;
    using Domain.Entities;
    using Dto;
    using Queries.Abstractions;
    using Infrastructure.Pagination;

    public class CityGetListRequestHandler : IAsyncRequestHandler<CityGetListRequest, CityGetListResponse>
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;
        private readonly IMapper _mapper;



        public CityGetListRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, IMapper mapper)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }



        public async Task<CityGetListResponse> ExecuteAsync(CityGetListRequest request)
        {
            //List<City> cities;


            List<City> cities = await _asyncQueryBuilder
                    .For<List<City>>()
                    .WithAsync(new FindCitiesBySearchAndCountryId(request.Filter.CountryId, request.Filter.Search));
           
           

            if (request.Pagination != null)
            {
                cities = cities.GetRange(request.Pagination.Offset, request.Pagination.Count);
            }


            return new CityGetListResponse(
                new PaginatedList<CityListItemDto>(cities.Count, _mapper.Map<IEnumerable<CityListItemDto>>(cities))
                );

        }
    }
}
