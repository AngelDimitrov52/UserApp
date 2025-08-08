using AutoMapper;
using FluentValidation;
using src.Core.Application.Models.UserModels.Dtos;
using src.Core.Application.Models.UserModels.Interfaces;
using src.Core.Domain.Entities;

namespace src.Core.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(
            IUserRepository userRepositor,
            IMapper mapper)
        {
            _userRepository = userRepositor;
            _mapper = mapper;
        }

        public IEnumerable<UserGetDto> GetAll()
        {
            var users = _userRepository.GetAll();

            var result = _mapper.Map<IEnumerable<UserGetDto>>(users);

            return result;
        }

        public UserGetDto GetById(int id) =>
            _mapper.Map<UserGetDto>(_userRepository.GetById(id));

        public UserGetDto Create(UserCreateDto userCreateDto)
        {
            // Map the DTO to the User entity
            var userCreate = _mapper.Map<User>(userCreateDto);

            // Generate UserId
            userCreate.Id = GenerateUserId();
            
            // Add User
            var user = _userRepository.Add(userCreate);

            //Map the User entity back to UserGetDto
            var userGetDto = _mapper.Map<UserGetDto>(user);

            //Return the UserGetDto
            return userGetDto;
        }

        public UserGetDto Update(UserUpdateDto userUpdateDto)
        {
            var userUpdate = _mapper.Map<User>(userUpdateDto);
            
            var user = _userRepository.Update(userUpdate);
            
            return _mapper.Map<UserGetDto>(user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        private int GenerateUserId() => _userRepository.GetAll().Count() + 1;
    }
}