using JobApplicationTracker.Application.DTOs;
using JobApplicationTracker.Application.Interfaces;
using JobApplicationTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationTracker.Application.Services
{
    public class JobApplicationService : IJobApplicationService
    {
        private readonly IJobApplicationRepository _repository;

        public JobApplicationService(IJobApplicationRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<JobApplicationDto>> GetAllAsync(PaginationParameters paginationParams)
        {
            var jobs = await _repository.GetAllAsync(paginationParams);

            return jobs.Select(j => new JobApplicationDto
            {
                Id = j.Id,
                CompanyName = j.CompanyName,
                Position = j.Position,
                DateApplied = j.DateApplied,
                Status = j.Status
            });
        }




        public async Task<JobApplicationDto?> GetByIdAsync(int id)
        {
            var job = await _repository.GetByIdAsync(id);
            if (job == null)
                return null;

            return new JobApplicationDto
            {
                Id = job.Id,
                CompanyName = job.CompanyName,
                Position = job.Position,
                DateApplied = job.DateApplied,
                Status = job.Status
            };
        }

        public async Task<JobApplicationDto> CreateAsync(CreateJobApplicationDto dto)
        {
            var job = new JobApplication
            {
                CompanyName = dto.CompanyName,
                Position = dto.Position,
                DateApplied = dto.DateApplied,
                Status = dto.Status
            };

            var created = await _repository.AddAsync(job);

            return new JobApplicationDto
            {
                Id = created.Id,
                CompanyName = created.CompanyName,
                Position = created.Position,
                DateApplied = created.DateApplied,
                Status = created.Status
            };
        }

        public async Task<JobApplicationDto?> UpdateAsync(int id, UpdateJobApplicationDto dto)
{
    var existing = await _repository.GetByIdAsync(id);
    if (existing == null)
        return null;

    existing.CompanyName = dto.CompanyName;
    existing.Position = dto.Position;
    existing.DateApplied = dto.DateApplied;
    existing.Status = dto.Status;

    await _repository.UpdateAsync(existing);

    return new JobApplicationDto
    {
        Id = existing.Id,
        CompanyName = existing.CompanyName,
        Position = existing.Position,
        DateApplied = existing.DateApplied,
        Status = existing.Status
    };
}

    }
}
