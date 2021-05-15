using FluentValidation;
using Support.Domain;

namespace Support.Persistence.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.username).NotNull().WithMessage("Username is required");

            RuleFor(u => u.email).NotNull().WithMessage("Email is required");
            RuleFor(u => u.email).EmailAddress().WithMessage("Email format invalid");
        }
    }
}
