using FluentValidation;

namespace WebApplication1
{
    public class PostCommandValidator : AbstractValidator<PostCommand>
    {
        public PostCommandValidator()
        {
            RuleFor(model => model.Age).GreaterThan(0);
            RuleFor(model => model.Name).NotEmpty();
        }
    }
}