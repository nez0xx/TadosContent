namespace Content.Domain.Criteria
{
    using Queries.Abstractions;

    public record FindBySearch(string Search) : ICriterion;
}