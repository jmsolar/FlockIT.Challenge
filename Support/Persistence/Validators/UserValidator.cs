using FluentValidation;
using Support.Domain;

namespace Support.Persistence.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.username).NotNull();

            RuleFor(u => u.email).NotNull();
            RuleFor(u => u.email).EmailAddress();
        }
    }
}
