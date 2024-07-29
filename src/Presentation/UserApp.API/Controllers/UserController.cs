using Microsoft.AspNetCore.Mvc;
using src.Core.Application.Models.UserModels.Dtos;
using src.Core.Application.Models.UserModels.Interfaces;
using src.Core.Domain.Entities;

namespace src.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetUsers();
        }

        [HttpGet]
        [Route("{id}")]
        public User GetById(int id)
        {
            return _userService.GetUser(id);
        }

        [HttpPost]
        public void Post([FromBody] UserCreateDto user)
        {
            _userService.CreateUser(user);
        }

        [HttpPut]
        public void Put([FromBody] User user)
        {
            _userService.UpdateUser(user);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _userService.DeleteUser(id);
        }
    }
}
