using src.Core.Application.Models.UserModels.Dtos;
using src.Core.Application.Models.UserModels.Interfaces;
using src.Core.Domain.Entities;

namespace src.Core.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUser(int id)
        {
            return _userRepository.GetById(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public void CreateUser(UserCreateDto userDto)
        {
            var user = new User
            {
                Id = GenerateUserId(),
                Name = userDto.Name,
                Email = userDto.Email
            };

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