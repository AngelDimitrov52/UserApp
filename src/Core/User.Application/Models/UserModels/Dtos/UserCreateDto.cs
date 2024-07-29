using src.Core.Domain.Enums;

namespace src.Core.Application.Models.UserModels.Dtos
{
    public class UserCreateDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public UserEnum Enum { get; set; }
    }
}
