//using FluentValidation;

namespace src.Core.Application.Helpers.Validators
{
    public class UserCreateDtoValidator //: AbstractValidator<UserCreateDto>
    {
        public UserCreateDtoValidator()
        {
            //RuleFor(t => t.Email)
            //     .NotEmpty().WithMessage("Email can not be empty!")
            //        .NotNull().WithMessage("Email can not be null!")
            //        .Length(1, 100);
        }
    }
}
