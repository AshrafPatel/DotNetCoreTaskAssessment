using HMCTS.TaskTracker.Data;
using HMCTS.TaskTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMCTS.TaskTracker.Repositories.Tasks
{
    public interface ITaskRepository
    {
        Task<TaskEntity> AddAsync(TaskEntity taskData);
        Task<bool> DeleteAsync(Guid id);
        Task<List<TaskEntity>> GetAllContacts();
        Task<TaskEntity?> GetContactAsync(Guid id);
        Task<TaskEntity?> UpdateAsync(Guid id, TaskEntity taskData);
    }
}
