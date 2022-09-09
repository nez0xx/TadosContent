namespace Content.WebApi.Controllers.Country.Actions.Edit
{
    using Api.Requests.Abstractions;
    public record CountryEditRequest : IRequest
    {
        public long Id { get; set; }
        
        public string Name { get; set; }
    }
}