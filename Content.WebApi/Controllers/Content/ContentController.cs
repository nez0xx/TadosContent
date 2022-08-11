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


    [ApiController]
    [Route("api/content")]
    public class ContentController : Controller
    {
        [HttpPost]
        [Route("createArticle")]
        [ProducesResponseType(typeof(ContentCreateResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> CreateArticle(ContentCreateArticleRequest request) => throw new NotImplementedException();

        [HttpPost]
        [Route("createVideo")]
        [ProducesResponseType(typeof(ContentCreateResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> CreateVideo(ContentCreateVideoRequest request) => throw new NotImplementedException();
        
        [HttpPost]
        [Route("createGallery")]
        [ProducesResponseType(typeof(ContentCreateResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> CreateGallery(ContentCreateGalleryRequest request) => throw new NotImplementedException();
        
        [HttpPost]
        [Route("editArticle")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> EditArticle(ContentEditArticleRequest request) => throw new NotImplementedException();

        [HttpPost]
        [Route("editVideo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> EditVideo(ContentEditVideoRequest request) => throw new NotImplementedException();
        
        [HttpPost]
        [Route("editGallery")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> EditGallery(ContentEditGalleryRequest request) => throw new NotImplementedException();

        [HttpPost]
        [Route("rate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Rate(ContentRateRequest request) => throw new NotImplementedException();
        
        [HttpPost]
        [Route("get")]
        [ProducesResponseType(typeof(ContentGetResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Get(ContentGetRequest request) => throw new NotImplementedException();

        [HttpPost]
        [Route("getList")]
        [ProducesResponseType(typeof(ContentGetListResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Task<IActionResult> Get(ContentGetListRequest request) => throw new NotImplementedException();
    }
}