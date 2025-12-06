using HMCTS.TaskTracker.Data;
using HMCTS.TaskTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMCTS.TaskTracker.Services.Tasks
{
    public interface ITaskService
    {
        Task<TaskEntity> AddTaskAsync(TaskEntity taskData);
        Task<bool> DeleteTaskAsync(Guid id);
        Task<List<TaskEntity>> GetAllTasksAsync();
        Task<TaskEntity?> GetTaskAsync(Guid id);
        Task<TaskEntity?> UpdateTaskAsync(Guid id, TaskEntity taskData);
    }
}
