namespace Content.WebApi.Controllers.Country
{
    using System;
    using System.Threading.Tasks;
    using Actions.Create;
    using Actions.Edit;
    using Actions.Get;
    using Actions.GetList;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;


    [ApiController]
    [Route("api/country")]
    public class CountryController : Controller
    {
        [HttpPost]
        [Route("create")]
        [ProducesResponseType(typeof(CountryCreateResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Create(CountryCreateRequest request) => throw new NotImplementedException();

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