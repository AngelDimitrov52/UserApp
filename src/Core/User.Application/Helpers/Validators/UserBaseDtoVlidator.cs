using FluentValidation;
using src.Core.Application.Models.UserModels.Dtos;

namespace src.Core.Application.Helpers.Validators;

public class UserBaseDtoVlidator : AbstractValidator<UserBaseDto>
{
    public UserBaseDtoVlidator()
    {
        RuleFor(t => t.Email)
            .NotNull().WithMessage("Email can not be null!")
            .NotEmpty().WithMessage("Email is required!")
            .Length(5, 100).WithMessage("The Email must be between 5 and 100 characters long!");

        RuleFor(user => user.Username)
            .NotNull().WithMessage("Username can not be null!")
            .NotEmpty().WithMessage("Username is required!")
            .Length(2, 50).WithMessage("The Username must be between 2 and 50 characters long!");
    }
}