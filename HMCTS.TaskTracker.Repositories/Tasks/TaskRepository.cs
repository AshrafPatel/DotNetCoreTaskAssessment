using HMCTS.TaskTracker.Data;
using HMCTS.TaskTracker.Data.Data;
using HMCTS.TaskTracker.Data.Models;
using Microsoft.Extensions.Logging;

namespace HMCTS.TaskTracker.Repositories.Tasks
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskDbContext _dbContext;
        private readonly ILogger<TaskRepository> _logger;
        public TaskRepository(TaskDbContext taskDbContext, ILogger<TaskRepository> logger)
        {
            _dbContext = taskDbContext ?? throw new ArgumentNullException(nameof(taskDbContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public Task<TaskEntity> AddAsync(TaskEntity taskData)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TaskEntity>> GetAllContacts()
        {
            throw new NotImplementedException();
        }

        public Task<TaskEntity?> GetContactAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskEntity?> UpdateAsync(Guid id, TaskEntity taskData)
        {
            throw new NotImplementedException();
        }
    }
}
