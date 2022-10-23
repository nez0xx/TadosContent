namespace Content.WebApi.Controllers.Country.Proifiles { 
    using AutoMapper;
    using Domain.Entities;
    using Dto;

    public class FoodProfile : Profile
    {
        public FoodProfile()
        {
            CreateMap<Country, CountryDto>();
        }
    }
}
