using src.Core.Application.Models.UserModels.Dtos;
using src.Core.Domain.Entities;

namespace src.Core.Application.Models.UserModels.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserGetDto> GetAll();
        UserGetDto GetById(int id);
        UserGetDto Create(UserCreateDto user);
        UserGetDto Update(UserUpdateDto user);
        void Delete(int id);
    }
}
