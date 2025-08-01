using JobApplicationTracker.Domain.Entities;
using JobApplicationTracker.Application.DTOs;

namespace JobApplicationTracker.Application.Interfaces
{
    public interface IJobApplicationRepository
    {
        Task<IEnumerable<JobApplication>> GetAllAsync(PaginationParameters paginationParams);
        Task<JobApplication?> GetByIdAsync(int id);
        Task<JobApplication> AddAsync(JobApplication job);
        Task UpdateAsync(JobApplication job);
    }
}
