namespace Content.WebApi.Controllers.User
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
    [Route("api/user")]
    public class UserController : Controller
    {
        [HttpPost]
        [Route("create")]
        [ProducesResponseType(typeof(UserCreateResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Create(UserCreateRequest request) => throw new NotImplementedException();

        [HttpPost]
        [Route("edit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Edit(UserEditRequest request) => throw new NotImplementedException();

        [HttpPost]
        [Route("get")]
        [ProducesResponseType(typeof(UserGetResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Get(UserGetRequest request) => throw new NotImplementedException();

        [HttpPost]
        [Route("getList")]
        [ProducesResponseType(typeof(UserGetListResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Get(UserGetListRequest request) => throw new NotImplementedException();
    }
}