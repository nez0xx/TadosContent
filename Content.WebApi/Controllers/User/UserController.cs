namespace Content.WebApi.Controllers.User
{
    using System;
    using Controllers;
    using Actions.Get;
    using Actions.Edit;
    using Actions.Create;
    using Actions.GetList;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Api.Requests.Abstractions;
    using Microsoft.AspNetCore.Http;
    using AspnetCore.ApiControllers.Extensions;
    using Api.Requests.Hierarchic.Abstractions;
    using global::Persistence.Transactions.Behaviors;


    [ApiController]
    [Route("api/user")]
    public class UserController : ContentApiControllerBase
    {
        public UserController(
            IAsyncRequestBuilder asyncRequestBuilder,
            IAsyncHierarchicRequestBuilder asyncHierarchicRequestBuilder,
            IExpectCommit commitPerformer)
            : base(
                asyncRequestBuilder,
                asyncHierarchicRequestBuilder,
                commitPerformer)
        {

        }

        [HttpPost]
        [Route("create")]
        [ProducesResponseType(typeof(UserCreateResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Create(UserCreateRequest request)
                    => this.RequestAsync()
                      .For<UserCreateResponse>()
                      .With(request);

        [HttpPost]
        [Route("edit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Edit(UserEditRequest request) => this.RequestAsync(request);

        [HttpPost]
        [Route("get")]
        [ProducesResponseType(typeof(UserGetResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Get(UserGetRequest request)
                   => this.RequestAsync()
                      .For<UserGetResponse>()
                      .With(request);

        [HttpPost]
        [Route("getList")]
        [ProducesResponseType(typeof(UserGetListResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Get(UserGetListRequest request) 
                    => this.RequestAsync()
                      .For<UserGetListResponse>()
                      .With(request);
    }
}