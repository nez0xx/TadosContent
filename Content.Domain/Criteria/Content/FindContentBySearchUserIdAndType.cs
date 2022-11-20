namespace Content.Domain.Criteria
{
    using Queries.Abstractions;
    using Enums;
    public record FindContentBySearchUserIdAndType(ContentType? Type, long? UserId, string Search) : ICriterion;

}
