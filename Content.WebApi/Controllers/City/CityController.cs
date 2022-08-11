namespace Content.WebApi.Controllers.City
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
    [Route("api/city")]
    public class CityController : Controller
    {
        [HttpGet]
        [Route("create")]
        [ProducesResponseType(typeof(CityCreateResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Create(CityCreateRequest request) => throw new NotImplementedException();

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