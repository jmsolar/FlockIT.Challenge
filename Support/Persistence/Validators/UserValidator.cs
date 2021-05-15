using FluentValidation;
using Support.Domain;

namespace Support.Persistence.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.username).NotNull();

            RuleFor(u => u.password).NotNull();
        }
    }
}
