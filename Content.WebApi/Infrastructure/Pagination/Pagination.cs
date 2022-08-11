namespace Content.WebApi.Infrastructure.Pagination
{
    public record Pagination
    {
        public int Offset { get; set; }
        
        public int Count { get; set; }
    }
}