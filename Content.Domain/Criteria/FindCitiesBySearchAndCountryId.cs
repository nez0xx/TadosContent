namespace Content.Domain.Criteria
{
    using Queries.Abstractions;
    public record FindCitiesBySearchAndCountryId(long? CountryId, string Search) : ICriterion;

}
