using HMCTS.TaskTracker.Data;
using HMCTS.TaskTracker.Data.Data;
using HMCTS.TaskTracker.Data.Models;
using Microsoft.EntityFrameworkCore;
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
        public async Task<TaskEntity> AddAsync(TaskEntity taskData)
        {
            if (taskData == null)
            {
                throw new ArgumentNullException(nameof(taskData));
            }
            taskData.Id = Guid.NewGuid();
            await _dbContext.AddAsync(taskData);
            await _dbContext.SaveChangesAsync();
            _logger.LogInformation("Added new task with ID {TaskId}", taskData.Id);
            return taskData;
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TaskEntity>> GetAllTasks()
        {
            _logger.LogInformation("Retrieving all tasks from the database.");
            List<TaskEntity> contacts = await _dbContext.Tasks.ToListAsync();
            _logger.LogInformation("Retrieved {Count} contacts from database", contacts.Count);

            return contacts;
        }

        public async Task<TaskEntity?> GetTaskAsync(Guid id)
        {
            _logger.LogInformation("Retrieving task with ID {TaskId} from the database.", id);
            if (id == Guid.Empty)
            {
                throw new ArgumentException($"Invalid Task ID {id}");
            }
            TaskEntity? task = await _dbContext.Tasks.SingleOrDefaultAsync(x => x.Id == id);
            return task;
        }

        public Task<TaskEntity?> UpdateAsync(Guid id, TaskEntity taskData)
        {
            throw new NotImplementedException();
        }
    }
}
