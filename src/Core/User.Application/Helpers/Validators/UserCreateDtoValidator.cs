//using FluentValidation;

using FluentValidation;
using src.Core.Application.Models.UserModels.Dtos;

namespace src.Core.Application.Helpers.Validators
{
    public class UserCreateDtoValidator : AbstractValidator<UserCreateDto>
    {
        public UserCreateDtoValidator()
        {
            RuleFor(t => t.Email)
                 .NotEmpty().WithMessage("Email can not be empty!")
                    .NotNull().WithMessage("Email can not be null!")
                    .Length(1, 100);
            
             RuleFor(user => user.Username)
                 .NotEmpty().WithMessage("Username is required")
                 .Length(1, 50).WithMessage("Username can't be longer than 50 characters");
            
             RuleFor(user => user.Email)
                 .NotEmpty().WithMessage("Email is required")
                 .EmailAddress().WithMessage("Invalid email format");
        }
    }
}
