namespace Content.WebApi.Controllers.Content
{
    using System;
    using System.Threading.Tasks;
    using Actions.Create;
    using Actions.Edit;
    using Actions.Get;
    using Actions.GetList;
    using Actions.Rate;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Api.Requests.Abstractions;
    using Api.Requests.Hierarchic.Abstractions;
    using AspnetCore.ApiControllers.Extensions;
    using global::Persistence.Transactions.Behaviors;

    [ApiController]
    [Route("api/content")]
    public class ContentController : ContentApiControllerBase
    {
        public ContentController(
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
        [ProducesResponseType(typeof(ContentCreateHierarchicResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> CreateContent(ContentCreateHierarchicRequestBase request) => 
            this.HierarchicRequestAsync()
                .For<ContentCreateHierarchicResponse>()
                .With(request);     

        [HttpPost]
        [Route("edit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> EditContent(ContentEditHierarchicRequestBase request) => this.HierarchicRequestAsync(request);

        [HttpPost]
        [Route("rate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Rate(ContentRateRequest request) => this.RequestAsync(request);
        
        [HttpPost]
        [Route("get")]
        [ProducesResponseType(typeof(ContentGetResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Get(ContentGetRequest request) 
                                => this.RequestAsync()
                                  .For<ContentGetResponse>()
                                  .With(request);

        [HttpPost]
        [Route("getList")]
        [ProducesResponseType(typeof(ContentGetListResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Get(ContentGetListRequest request) => 
            this.RequestAsync()
            .For<ContentGetListResponse>()
            .With(request);
    }
}