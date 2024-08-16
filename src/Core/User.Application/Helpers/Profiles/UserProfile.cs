using AutoMapper;
using src.Core.Application.Models.UserModels.Dtos;
using src.Core.Domain.Entities;

namespace src.Core.Application.Helpers.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreateDto, User>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Username)).ReverseMap();
            
            // // Map from UserDTO to User
            // CreateMap<UserCreateDto, User>()
            //     .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Username));
            //
            // // Map from User to UserDTO
            // CreateMap<User, UserCreateDto>()
            //     .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Name));
        }
    }
}