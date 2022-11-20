namespace Content.Domain.Criteria
{
    using Queries.Abstractions;
    public record FindArticlesBySearchAndUserId(long? UserId, string Search) : ICriterion;

}
