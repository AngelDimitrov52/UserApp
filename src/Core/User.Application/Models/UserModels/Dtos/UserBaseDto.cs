using src.Core.Domain.Enums;

namespace src.Core.Application.Models.UserModels.Dtos;

public class UserBaseDto
{
    public string Username { get; set; }
    public string Email { get; set; }
    public UserEnum Enum { get; set; }
}