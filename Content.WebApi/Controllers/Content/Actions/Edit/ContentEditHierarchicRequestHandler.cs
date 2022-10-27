namespace Content.WebApi.Controllers.Content.Actions.Edit
{
    using System;
    using System.Threading.Tasks;
    using Api.Requests.Hierarchic.Abstractions;
    using Domain.Criteria;
    using Domain.Entities;
    using Queries.Abstractions;

    public abstract class ContentEditHierarchicRequestHandler<TConcreteContentHierarchicRequest> : AsyncHierarchicRequestHandlerBase<TConcreteContentHierarchicRequest>
        where TConcreteContentHierarchicRequest: ContentEditHierarchicRequestBase
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;



        protected ContentEditHierarchicRequestHandler(IAsyncQueryBuilder asyncQueryBuilder)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
        }



        protected override async Task ExecuteAsync(TConcreteContentHierarchicRequest request)
        {
             await EditContentAsync(
                id: request.Id,
                request: request);
        }



        protected abstract Task EditContentAsync(
            long id,
            TConcreteContentHierarchicRequest request);
    }
}
