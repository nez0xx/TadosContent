namespace Content.WebApi.Controllers.Country.Actions.Edit
{
    public record CountryEditRequest
    {
        public long Id { get; set; }
        
        public string Name { get; set; }
    }
}