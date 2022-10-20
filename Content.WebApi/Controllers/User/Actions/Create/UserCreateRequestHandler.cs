namespace Content.WebApi.Controllers.User.Actions.Create
{
    using System;
    using System.Threading.Tasks;
    using Api.Requests.Abstractions;
    using Domain.Criteria;
    using Domain.Entities;
    using Domain.Services.Users;
    using Queries.Abstractions;
    public class UserCreateRequestHandler : IAsyncRequestHandler<UserCreateRequest, UserCreateResponse>
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;
        private readonly IUserService _userService;



        public UserCreateRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, IUserService userService)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }



        public async Task<UserCreateResponse> ExecuteAsync(UserCreateRequest request)
        {
            City city = await _asyncQueryBuilder
                .For<City>()
                .WithAsync(new FindById(request.CityId));

            User user = await _userService.CreateUserAsync(
                email : request.Email,
                city: city
            );

            return new UserCreateResponse(user.Id);
        }
    }
}