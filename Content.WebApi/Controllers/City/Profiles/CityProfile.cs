namespace Content.WebApi.Controllers.City.Profiles { 
    using AutoMapper;
    using Domain.Entities;
    using Dto;

    public class CityProfile : Profile
    {
       
        public CityProfile()
        {

            CreateMap<City, CityDto>();
                //.ForMember(x => x.CountryDto, y => y.MapFrom(src => src.Country));
            CreateMap<City, CityListItemDto>()
                .ForMember(x => x.CountryName, y => y.MapFrom(src => src.Country.Name));
       
        }
    }
}
