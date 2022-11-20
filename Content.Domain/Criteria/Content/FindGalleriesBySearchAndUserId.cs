namespace Content.Domain.Criteria
{
    using Queries.Abstractions;

    public record FindGalleriesBySearchAndUserId(long? UserId, string Search) : ICriterion;
}
