using src.Core.Domain.Entities;

namespace src.Core.Application.Models.UserModels.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        
        User GetById(int id);
        
        User Add(User user);
        
        User Update(User user);
        
        void Delete(int id);
    }
}
