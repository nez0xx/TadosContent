namespace Content.WebApi.Controllers.Country.Actions.GetList
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

    public class CountryGetListRequestHandler : IAsyncRequestHandler<CountryGetListRequest, CountryGetListResponse>
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;
        private readonly IMapper _mapper;



        public CountryGetListRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, IMapper mapper)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }



        public async Task<CountryGetListResponse> ExecuteAsync(CountryGetListRequest request)
        {
            List<Country> countries = await _asyncQueryBuilder
                .For<List<Country>>()
                .WithAsync(new FindBySearch(request.Filter.Search));

            if (request.Pagination != null)
            {
                countries = countries.GetRange(request.Pagination.Offset, request.Pagination.Count);
            }

            return new CountryGetListResponse(
                new PaginatedList<CountryListItemDto>(countries.Count, _mapper.Map<IEnumerable<CountryListItemDto>>(countries))
                );
      
        }
    }
}
