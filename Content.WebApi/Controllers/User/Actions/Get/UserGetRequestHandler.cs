namespace Content.WebApi.Controllers.User.Actions.Get
{
    using System;
    using System.Threading.Tasks;
    using Api.Requests.Abstractions;
    using AutoMapper;
    using Domain.Criteria;
    using Domain.Entities;
    using Dto;
    using Queries.Abstractions;

    public class UserGetRequestHandler : IAsyncRequestHandler<UserGetRequest, UserGetResponse>
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;
        private readonly IMapper _mapper;



        public UserGetRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, IMapper mapper)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }



        public async Task<UserGetResponse> ExecuteAsync(UserGetRequest request)
        {
            User user = await _asyncQueryBuilder
                .For<User>()
                .WithAsync(new FindById(request.Id));

            return new UserGetResponse(_mapper.Map<UserDto>(user));
        }
    }
}
