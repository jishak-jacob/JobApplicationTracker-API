using JobApplicationTracker.Application.Interfaces;
using JobApplicationTracker.Domain.Entities;
using JobApplicationTracker.Application.DTOs;
using JobApplicationTracker.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace JobApplicationTracker.Infrastructure.Repositories
{
    public class JobApplicationRepository : IJobApplicationRepository
    {
        private readonly ApplicationDbContext _context;

        public JobApplicationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<JobApplication>> GetAllAsync(PaginationParameters paginationParams)
        {
            return await _context.JobApplications
                .Skip((paginationParams.PageNumber - 1) * paginationParams.PageSize)
                .Take(paginationParams.PageSize)
                .ToListAsync();
        }

        public async Task<JobApplication?> GetByIdAsync(int id)
        {
            return await _context.JobApplications.FindAsync(id);
        }

        public async Task<JobApplication> AddAsync(JobApplication job)
        {
            _context.JobApplications.Add(job);
            await _context.SaveChangesAsync();
            return job;
        }

        public async Task UpdateAsync(JobApplication job)
        {
            _context.JobApplications.Update(job);
            await _context.SaveChangesAsync();
        }
    }
}
