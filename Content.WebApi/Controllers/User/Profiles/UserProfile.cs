namespace Content.WebApi.Controllers.User.Profiles { 
    using AutoMapper;
    using Domain.Entities;
    using Dto;

    public class UserProfile : Profile
    {
       
        public UserProfile()
        {

            CreateMap<User, UserDto>();
            CreateMap<User, UserListItemDto>()
                .ForMember(d => d.CityFullName, opts => opts.MapFrom(src => string.Concat(src.City.Country.Name, ", ", src.City.Name))); 
       
        }
    }
}
