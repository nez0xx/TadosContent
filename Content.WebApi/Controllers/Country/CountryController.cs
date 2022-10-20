namespace Content.WebApi.Controllers.Country
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
    [Route("api/country")]
    public class CountryController : ContentApiControllerBase
    {
        public CountryController(
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
        [ProducesResponseType(typeof(CountryCreateResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Create(CountryCreateRequest request) => this.RequestAsync()
                .For<CountryCreateResponse>()
                .With(request);

        [HttpPost]
        [Route("edit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Edit(CountryEditRequest request) => throw new NotImplementedException();

        [HttpPost]
        [Route("get")]
        [ProducesResponseType(typeof(CountryGetResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Get(CountryGetRequest request) => throw new NotImplementedException();

        [HttpPost]
        [Route("getList")]
        [ProducesResponseType(typeof(CountryGetListResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Get(CountryGetListRequest request) => throw new NotImplementedException();
    }
}