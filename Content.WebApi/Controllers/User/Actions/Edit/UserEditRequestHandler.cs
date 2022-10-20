namespace Content.WebApi.Controllers.User.Actions.Edit 
{
    using System;
    using System.Threading.Tasks;
    using Api.Requests.Abstractions;
    using Domain.Criteria;
    using Domain.Entities;
    using Domain.Services.Users;
    using Queries.Abstractions;
    public class UserEditRequestHandler : IAsyncRequestHandler<UserEditRequest>
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;
        private readonly IUserService _userService;



        public UserEditRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, IUserService userService)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }



        public async Task ExecuteAsync(UserEditRequest request)
        {
            User user = await _asyncQueryBuilder
                .For<User>()
                .WithAsync(new FindById(request.Id));

             await _userService.UpdateUserAsync(user, request.Id);

        }
    }
}