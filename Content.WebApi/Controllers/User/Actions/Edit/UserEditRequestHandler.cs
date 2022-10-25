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



        public UserEditRequestHandler(IAsyncQueryBuilder asyncQueryBuilder)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
        }



        public async Task ExecuteAsync(UserEditRequest request)
        {
            User user = await _asyncQueryBuilder
                .For<User>()
                .WithAsync(new FindById(request.Id));

            if (request.CityId != null)
            {
                City city = await _asyncQueryBuilder
                .For<City>()
                .WithAsync(new FindById(request.CityId.Value));

                user.SetCity(city);

            }
        }
    }
}