using src.Core.Application.Models.UserModels.Dtos;
using src.Core.Domain.Entities;

namespace src.Core.Application.Models.UserModels.Interfaces
{
    public interface IUserService
    {
        User GetUser(int id);
        IEnumerable<User> GetUsers();
        void CreateUser(UserCreateDto user);
        public void UpdateUser(User user);
        public void DeleteUser(int id);
    }
}
