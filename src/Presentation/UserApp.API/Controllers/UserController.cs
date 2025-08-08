using Microsoft.AspNetCore.Mvc;
using src.Core.Application.Models.UserModels.Dtos;
using src.Core.Application.Models.UserModels.Interfaces;

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
        public IEnumerable<UserGetDto> GetAll()
        {
            return _userService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public UserGetDto GetById(int id)
        {
            return _userService.GetById(id);
        }

        [HttpPost]
        public UserGetDto Post([FromBody] UserCreateDto user)
        {
           return _userService.Create(user);
        }

        [HttpPut]
        public UserGetDto Put([FromBody] UserUpdateDto user)
        {
           return _userService.Update(user);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _userService.Delete(id);
        }
    }
}