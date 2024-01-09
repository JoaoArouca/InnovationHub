using Application.UseCases.User.Create;
using FluentValidation;

namespace Application.Validators.User
{
    public class CreateUserValidator : AbstractValidator<CreateUserInput>
    {
        public CreateUserValidator()
        {
            RuleFor(input => input.Email)
                .NotEmpty().WithMessage("Email field must not be empty")
                .EmailAddress().WithMessage("Invalid email address")
                .WithErrorCode("1001");

            RuleFor(input => input.Password)
                .NotEmpty().WithMessage("Password field must not be empty")
                .MinimumLength(6).WithMessage("Password must have at least 6 characters")
                .WithErrorCode("1002");

            RuleFor(input => input.Name)
                .NotEmpty().WithMessage("Name field must not be empty")
                .MinimumLength(3).WithMessage("Name must have at least 3 characters")
                .WithErrorCode("1003");
        }
    }
}
