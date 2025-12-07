using AutoMapper;
using HMCTS.TaskTracker.Data.Models;
using HMCTS.TaskTracker.Dto;
using HMCTS.TaskTracker.Repositories.Tasks;
using Microsoft.Extensions.Logging;

namespace HMCTS.TaskTracker.Services.Tasks
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ILogger<TaskService> _logger;
        private readonly IMapper _mapper;

        public TaskService(ITaskRepository taskRepository, ILogger<TaskService> logger, IMapper mapper)
        {
            _taskRepository = taskRepository ?? throw new ArgumentNullException(nameof(taskRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<TaskDto>? AddTaskAsync(TaskDto taskDto)
        {
            try
            {
                _logger.LogInformation("Attempting to add a new task.");
                if (taskDto == null)
                {
                    _logger.LogWarning("taskDto provided is null.");
                    return null;
                }
                TaskEntity taskToAdd = _mapper.Map<TaskEntity>(taskDto);
                taskToAdd = await _taskRepository.AddAsync(taskToAdd);
                _logger.LogInformation("Successfully added a new task with ID {TaskId}.", taskToAdd.Id);
                return taskDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding a new contact.");
                throw;
            }
        }

        public Task<bool> DeleteTaskAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TaskDto>> GetAllTasksAsync()
        {
            List<TaskDto>? taskDtos = null;
            try
            {
                _logger.LogInformation("Retrieving all tasks.");
                List<TaskEntity> tasksRaw = await _taskRepository.GetAllTasks();
                taskDtos = _mapper.Map<List<TaskDto>>(tasksRaw);
                return taskDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving all tasks.");
                throw;
            }
        }

        public Task<TaskDto?> GetTaskAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskDto?> UpdateTaskAsync(Guid id, TaskDto taskData)
        {
            throw new NotImplementedException();
        }
    }
}
