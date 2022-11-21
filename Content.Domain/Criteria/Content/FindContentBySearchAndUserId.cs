namespace Content.Domain.Criteria
{
    using Queries.Abstractions;
    public record FindContentBySearchAndUserId(long? UserId, string Search) : ICriterion;

}
