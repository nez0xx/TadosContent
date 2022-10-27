namespace Content.WebApi.Controllers.Content.Actions.Edit
{
    using System.ComponentModel.DataAnnotations;
    using Api.Requests.Hierarchic.Abstractions;
    using Common.DataAnnotations.Hierarchy;
    using Domain.Enums;


    public abstract record ContentEditHierarchicRequestBase : IHierarchicRequest
    {
        public long Id { get; set; }

        [Required]
        [HierarchyDiscriminator]
        public ContentType Type { get; set; }

        public string Title { get; set; }
    }
}