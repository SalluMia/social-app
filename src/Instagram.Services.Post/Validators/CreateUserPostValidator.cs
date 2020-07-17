using FluentValidation;
using Instagram.Common.DTOs.Post;

namespace Instagram.Services.Post.Validators
{
    public class CreateUserPostValidator : AbstractValidator<UserPostCreateDto>
    {
        public CreateUserPostValidator()
        {
            RuleFor(x => x.Type)
                .NotEmpty().WithMessage("Type is required.");

            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description is required.");

            RuleFor(x => x.Url)
                .NotEmpty().WithMessage("Url is required.");
        }
    }
}