namespace src.Core.Application.Models.UserModels.Dtos;

public abstract class UserWithIdDto : UserBaseDto
{
    public int Id { get; set; }
}