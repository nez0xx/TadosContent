namespace Content.Domain.Criteria
{
    using Queries.Abstractions;

    public class FindById : ICriterion
    {
        public FindById(long id)
        {
            Id = id;
        }
        
        public long Id { get; set; }
    }
}