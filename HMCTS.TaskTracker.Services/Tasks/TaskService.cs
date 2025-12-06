using HMCTS.TaskTracker.Data.Models;

namespace HMCTS.TaskTracker.Services.Tasks
{
    public class TaskService : ITaskService
    {

        public TaskService()
        {
            
        }
        public Task<TaskEntity> AddTaskAsync(TaskEntity taskData)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTaskAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TaskEntity>> GetAllTasksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TaskEntity?> GetTaskAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskEntity?> UpdateTaskAsync(Guid id, TaskEntity taskData)
        {
            throw new NotImplementedException();
        }
    }
}
