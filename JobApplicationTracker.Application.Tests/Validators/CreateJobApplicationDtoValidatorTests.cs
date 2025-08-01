using FluentAssertions;
using JobApplicationTracker.Application.DTOs;
using JobApplicationTracker.Application.Validators;

namespace JobApplicationTracker.Application.Tests.Validators
{
    public class CreateJobApplicationDtoValidatorTests
    {
        private readonly CreateJobApplicationDtoValidator _validator;

        public CreateJobApplicationDtoValidatorTests()
        {
            _validator = new CreateJobApplicationDtoValidator();
        }

        [Fact]
        public void Should_Have_Error_When_CompanyName_Is_Empty()
        {
            var dto = new CreateJobApplicationDto
            {
                CompanyName = "",
                Position = "Developer",
                DateApplied = DateTime.Today,
                Status = Domain.Enums.ApplicationStatus.Applied
            };

            var result = _validator.Validate(dto);

            result.IsValid.Should().BeFalse();
            result.Errors.Should().ContainSingle(e => e.PropertyName == "CompanyName");
        }

        [Fact]
        public void Should_Have_Error_When_Position_Is_Empty()
        {
            var dto = new CreateJobApplicationDto
            {
                CompanyName = "DataCom",
                Position = "",
                DateApplied = DateTime.Today,
                Status = Domain.Enums.ApplicationStatus.Applied
            };

            var result = _validator.Validate(dto);

            result.IsValid.Should().BeFalse();
            result.Errors.Should().ContainSingle(e => e.PropertyName == "Position");
        }

        [Fact]
        public void Should_Have_Error_When_Date_Is_In_Future()
        {
            var dto = new CreateJobApplicationDto
            {
                CompanyName = "DataCom",
                Position = "Developer",
                DateApplied = DateTime.Today.AddDays(1),
                Status = Domain.Enums.ApplicationStatus.Applied
            };

            var result = _validator.Validate(dto);

            result.IsValid.Should().BeFalse();
            result.Errors.Should().ContainSingle(e => e.PropertyName == "DateApplied");
        }

        [Fact]
        public void Should_Pass_For_Valid_Input()
        {
            var dto = new CreateJobApplicationDto
            {
                CompanyName = "DataCom",
                Position = "Developer",
                DateApplied = DateTime.Today,
                Status = Domain.Enums.ApplicationStatus.Applied
            };

            var result = _validator.Validate(dto);

            result.IsValid.Should().BeTrue();
        }
    }
}
