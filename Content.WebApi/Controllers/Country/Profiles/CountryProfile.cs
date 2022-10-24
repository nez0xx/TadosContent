namespace Content.WebApi.Controllers.Country.Profiles { 
    using AutoMapper;
    using Domain.Entities;
    using Dto;

    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryDto>();
            CreateMap<Country, CountryListItemDto>();
        }
    }
}
