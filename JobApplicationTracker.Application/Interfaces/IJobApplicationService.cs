using JobApplicationTracker.Application.DTOs;

namespace JobApplicationTracker.Application.Interfaces
{
    public interface IJobApplicationService
    {
       Task<IEnumerable<JobApplicationDto>> GetAllAsync(PaginationParameters paginationParams);
        Task<JobApplicationDto?> GetByIdAsync(int id);
        Task<JobApplicationDto> CreateAsync(CreateJobApplicationDto dto);
        Task<JobApplicationDto?> UpdateAsync(int id, UpdateJobApplicationDto dto);
    }
}
