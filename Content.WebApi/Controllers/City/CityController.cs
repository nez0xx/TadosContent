namespace Content.WebApi.Controllers.City
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
    [Route("api/city")]
    public class CityController : ContentApiControllerBase
    {
        public CityController(
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
        [ProducesResponseType(typeof(CityCreateResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Create(CityCreateRequest request) => this.RequestAsync()
                .For<CityCreateResponse>()
                .With(request);
        [HttpPost]
        [Route("edit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Edit(CityEditRequest request) => throw new NotImplementedException();

        [HttpPost]
        [Route("get")]
        [ProducesResponseType(typeof(CityGetResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Get(CityGetRequest request) => throw new NotImplementedException();

        [HttpPost]
        [Route("getList")]
        [ProducesResponseType(typeof(CityGetListResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Get(CityGetListRequest request) => throw new NotImplementedException();
    }
}