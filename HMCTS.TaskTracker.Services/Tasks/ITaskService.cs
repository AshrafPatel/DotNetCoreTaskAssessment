using HMCTS.TaskTracker.Data;
using HMCTS.TaskTracker.Data.Models;
using HMCTS.TaskTracker.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMCTS.TaskTracker.Services.Tasks
{
    public interface ITaskService
    {
        Task<TaskDto>? AddTaskAsync(TaskDto taskData);
        Task<bool> DeleteTaskAsync(Guid id);
        Task<List<TaskDto>> GetAllTasksAsync();
        Task<TaskDto>? GetTaskAsync(Guid id);
        Task<TaskDto>? UpdateTaskAsync(Guid id, TaskDto taskData);
    }
}
