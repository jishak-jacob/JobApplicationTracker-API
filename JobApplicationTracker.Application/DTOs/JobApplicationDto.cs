using JobApplicationTracker.Domain.Enums;
using System;

namespace JobApplicationTracker.Application.DTOs
{
    public class JobApplicationDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public DateTime DateApplied { get; set; }
        public ApplicationStatus Status { get; set; }
    }
}
