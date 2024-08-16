using AutoMapper;
using src.Core.Application.Models.UserModels.Dtos;
using src.Core.Application.Models.UserModels.Interfaces;
using src.Core.Domain.Entities;

namespace src.Core.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepositor, IMapper mapper)
        {
            _userRepository = userRepositor;
            _mapper = mapper;
        }

        public User GetUser(int id)
        {
            return _userRepository.GetById(id);
        }

        public IEnumerable<UserGetDto> GetUsers()
        {
            var users = _userRepository.GetAll();
            return _mapper.Map<IEnumerable<UserGetDto>>(users);
        }

        public void CreateUser(UserCreateDto userDto)
        {
            var user = new User
            {
                Id = GenerateUserId(),
                Name = userDto.Username,
                Email = userDto.Email
            };

            user = _mapper.Map<User>(userDto);
            _userRepository.Add(user);
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
        }

        private int GenerateUserId() => _userRepository.GetAll().Count() + 1;

    }
}