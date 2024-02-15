using FluentValidation;

namespace WebDevelopment.Models.Dtos
{
    public class CreateCourseRequest
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string Code { get; set; } = default!;
        public int Unit { get; set; }
        public required IReadOnlyList<string> Lessons { get; set; }
    }

    //Data annotation or fluent validation for validating each field
    public class CreateCourseRequestValidator : AbstractValidator<CreateCourseRequest>
    {
        public CreateCourseRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Length cant be greater than 20");
            RuleFor(x => x.Code).NotEmpty().WithMessage("Code is required.");
            RuleFor(x => x.Unit).GreaterThan(0).WithMessage("Unit must be greater than 0.");
        }
    }
}
