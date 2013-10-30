using FluentValidation;
using WebApiFluentValidation.Models;

namespace WebApiFluentValidation.Validators
{
    public class TodoItemValidator : AbstractValidator<TodoItemDto>
    {
        ///
        /// Initializes a new instance of the  class.
        ///
        public TodoItemValidator()
        {
            RuleFor(item => item.Title)
                .NotEmpty();

            RuleFor(item => item.Title)
                .Length(5).WithMessage("Wrong length!!!");
        }
    }
}