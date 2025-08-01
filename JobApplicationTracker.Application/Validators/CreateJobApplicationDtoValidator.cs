using FluentValidation;
using JobApplicationTracker.Application.DTOs;
using System;

namespace JobApplicationTracker.Application.Validators
{
    public class CreateJobApplicationDtoValidator : AbstractValidator<CreateJobApplicationDto>
    {
        public CreateJobApplicationDtoValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("CompanyName is required.");
            RuleFor(x => x.Position).NotEmpty().WithMessage("Position is required.");
            RuleFor(x => x.DateApplied)
                .LessThanOrEqualTo(DateTime.Today)
                .WithMessage("DateApplied cannot be in the future.");
            RuleFor(x => x.Status).IsInEnum().WithMessage("Status must be valid.");
        }
    }
}
