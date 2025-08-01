using JobApplicationTracker.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace JobApplicationTracker.Application.DTOs
{
    public class CreateJobApplicationDto
    {
        [Required]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        public string Position { get; set; } = string.Empty;

        [Required]
        public DateTime DateApplied { get; set; }

        public ApplicationStatus Status { get; set; } = ApplicationStatus.Applied;
    }
}
