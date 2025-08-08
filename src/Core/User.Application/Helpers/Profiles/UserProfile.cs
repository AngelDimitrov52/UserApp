using AutoMapper;
using src.Core.Application.Models.UserModels.Dtos;
using src.Core.Domain.Entities;

namespace src.Core.Application.Helpers.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // Map from UserGetDto to User
            CreateMap<User, UserGetDto>()
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Name));
            
            // Map from UserCreateDto to User
            CreateMap<UserCreateDto, User>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Username))
                .ForMember(dest => dest.Created, opt => opt.MapFrom(src => DateTime.Now));
                
            // Map from UserUpdateDto to User
            CreateMap<UserUpdateDto, User>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Username));

            //.ReverseMap();
        }
    }
}