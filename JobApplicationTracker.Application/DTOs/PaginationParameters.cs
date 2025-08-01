// JobApplicationTracker.Application/DTOs/PaginationParameters.cs
namespace JobApplicationTracker.Application.DTOs
{
    public class PaginationParameters
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        public int Skip => (PageNumber - 1) * PageSize;
    }

}
