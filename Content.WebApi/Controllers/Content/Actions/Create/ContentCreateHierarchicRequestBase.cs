namespace Content.WebApi.Controllers.Content.Actions.Create
{
    using System.ComponentModel.DataAnnotations;
    using Api.Requests.Hierarchic.Abstractions;
    using Common.DataAnnotations.Hierarchy;
    using Domain.Enums;
    


    public abstract record ContentCreateHierarchicRequestBase : IHierarchicRequest<ContentCreateHierarchicResponse>
    {
        [Required]
        [HierarchyDiscriminator]
        public ContentType Type { get; init; }

        [Required]
        public string Title { get; init; }

        public long UserId { get; init; }
    }
}