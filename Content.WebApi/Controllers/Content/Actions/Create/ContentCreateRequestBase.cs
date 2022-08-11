namespace Content.WebApi.Controllers.Content.Actions.Create
{
    public abstract record ContentCreateRequestBase
    {
        public string Name { get; set; }

        public long UserId { get; set; }
    }
}