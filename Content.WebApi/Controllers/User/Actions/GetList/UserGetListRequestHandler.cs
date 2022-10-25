namespace Content.WebApi.Controllers.User.Actions.GetList
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

    public class UserGetListRequestHandler : IAsyncRequestHandler<UserGetListRequest, UserGetListResponse>
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;
        private readonly IMapper _mapper;



        public UserGetListRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, IMapper mapper)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }



        public async Task<UserGetListResponse> ExecuteAsync(UserGetListRequest request)
        {
            //List<City> cities;


            List<User> users = await _asyncQueryBuilder
                    .For<List<User>>()
                    .WithAsync(new FindBySearch(request.Filter.Search));
           
           

            if (request.Pagination != null)
            {
                users = users.GetRange(request.Pagination.Offset, request.Pagination.Count);
            }


            return new UserGetListResponse(
                new PaginatedList<UserListItemDto>(0, _mapper.Map<IEnumerable<UserListItemDto>>(users))
                );

        }
    }
}
