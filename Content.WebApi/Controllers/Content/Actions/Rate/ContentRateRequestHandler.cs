namespace Content.WebApi.Controllers.Content.Actions.Rate
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Api.Requests.Abstractions;
    using AutoMapper;
    using Domain.Criteria;
    using Domain.Entities;
    using Dto;
    using Queries.Abstractions;
    using Infrastructure.Pagination;
    using Domain.Services.Estimations;

    public class ContentRateRequestHandler : IAsyncRequestHandler<ContentRateRequest>
    {
        private readonly IAsyncQueryBuilder _asyncQueryBuilder;
        private readonly IRateService _rateService;
        private readonly IMapper _mapper;



        public ContentRateRequestHandler(IAsyncQueryBuilder asyncQueryBuilder, IRateService rateService, IMapper mapper)
        {
            _asyncQueryBuilder = asyncQueryBuilder ?? throw new ArgumentNullException(nameof(asyncQueryBuilder));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _rateService = rateService ?? throw new ArgumentNullException(nameof(rateService));
        }



        public async Task ExecuteAsync(ContentRateRequest request)
        {
            Content content = await _asyncQueryBuilder
                .For<Content>()
                .WithAsync(new FindById(request.ContentId));

            User user = await _asyncQueryBuilder
                .For<User>()
                .WithAsync(new FindById(request.UserId));

            _rateService.Rate(content, user, request.Digit);
        }
    }
}
