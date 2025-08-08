using FluentValidation;
using src.Core.Application.Models.UserModels.Dtos;

namespace src.Core.Application.Helpers.Validators
{
    public class UserCreateDtoValidator : AbstractValidator<UserCreateDto>
    {
        public UserCreateDtoValidator(
            IValidator<UserBaseDto> userBaseDtoValidator)
        {
            RuleFor(t => t.Password)
                .NotNull().WithMessage("Password can not be null!")
                .NotEmpty().WithMessage("Password can not be empty!")
                .Length(5, 100).WithMessage("The Password must be between 5 and 50 characters long!");
            
             RuleFor(user => user)
                 .SetValidator(userBaseDtoValidator);
              
        }
    }
}
