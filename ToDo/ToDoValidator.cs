using FluentValidation;

namespace TD.MinAPI;

public class ToDoValidator : AbstractValidator<ToDo>
{
    public ToDoValidator()
    {
        RuleFor(t => t.Value)
            .NotEmpty()
            .MinimumLength(5)
            .WithMessage("Value of a todo has to be atleast 5 characters");
    }
}
