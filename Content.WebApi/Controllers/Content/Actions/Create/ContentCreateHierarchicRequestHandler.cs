namespace Content.WebApi.Controllers.Content.Actions.Create
{
    using System;
    using System.Threading.Tasks;
    using Api.Requests.Hierarchic.Abstractions;
    using Domain.Criteria;
    using Domain.Entities;
    using Queries.Abstractions;

    public abstract class ContentCreateHierarchicRequestHandler<TConcreteContentHierarchicRequest> : AsyncHierarchicRequestHandlerBase<TConcreteContentHierarchicRequest, ContentCreateHierarchicResponse>
        where TConcreteContentHierarchicRequest: ContentCreateHierarchicRequestBase
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;



        protected ContentCreateHierarchicRequestHandler(IAsyncQueryBuilder asyncQueryBuilder)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
        }



        protected override async Task<ContentCreateHierarchicResponse> ExecuteAsync(TConcreteContentHierarchicRequest request)
        {
            User user = await _asyncQueryBuilder
                .For<User>()
                .WithAsync(new FindById(request.UserId));


            Content content = await CreateContentAsync(
                title: request.Title.Trim(),
                user: user,
                request: request);

            return new ContentCreateHierarchicResponse(
                Id: content.Id);
        }



        protected abstract Task<Content> CreateContentAsync(
            string title, 
            User user, 
            TConcreteContentHierarchicRequest request);
    }
}
