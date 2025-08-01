using JobApplicationTracker.Domain.Enums;

namespace JobApplicationTracker.Application.DTOs
{
    public class UpdateJobApplicationDto
    {
        public string? CompanyName { get; set; }
        public string? Position { get; set; }
        public DateTime DateApplied { get; set; }
        public ApplicationStatus Status { get; set; }
    }
}
