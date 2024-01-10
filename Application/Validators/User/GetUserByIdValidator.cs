using FluentValidation;

namespace Application.Validators.User
{
    public class GetUserByIdValidator : AbstractValidator<string>
    {
        public GetUserByIdValidator()
        {
            RuleFor(userId => userId)
                .NotEmpty().WithMessage("user id must not be empty")
                .Must(IsValidGUID).WithMessage("user id must be valid");
        }

        private bool IsValidGUID(string userId) => Guid.TryParse(userId, out _);
    }
}
