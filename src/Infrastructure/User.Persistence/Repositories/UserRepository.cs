using src.Core.Application.Models.UserModels.Interfaces;
using src.Core.Domain.Entities;

namespace src.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new();

        public IEnumerable<User> GetAll()
        {
            // Return all users
            return _users;
        }

        public User GetById(int id)
        {
            // Find the user by id and return it
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public User Add(User user)
        {
            // Add the user to the list
            _users.Add(user);

            return user;
        }

        public User Update(User user)
        {
            // Find the user by id and update it
            var existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                existingUser.Updated = DateTime.Now;
            }
            else
            {
                throw new Exception("User not found");
            }

            return user;
        }

        public void Delete(int id)
        {
            // Find the user by id and remove it
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }
    }
}