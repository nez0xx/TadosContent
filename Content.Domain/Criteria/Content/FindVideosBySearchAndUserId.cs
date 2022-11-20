namespace Content.Domain.Criteria
{
    using Queries.Abstractions;

    public record FindVideosBySearchAndUserId(long? UserId, string Search) : ICriterion;
}
