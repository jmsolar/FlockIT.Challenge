using FluentValidation;
using Support.Domain;

namespace Support.Persistence.Validators
{
    public class StateValidator : AbstractValidator<State>
    {
        public StateValidator()
        {
        }
    }
}
