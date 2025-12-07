using HMCTS.TaskTracker.Data.Models;
using HMCTS.TaskTracker.Dto;
using HMCTS.TaskTracker.Services.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HMCTS.TaskTracker.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskService _taskService;
        private readonly ILogger<TaskController> _logger;

        public TaskController(TaskService taskService, ILogger<TaskController> logger)
        {
            _taskService = taskService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTask([FromBody] TaskDto task)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(task.Title))
                return BadRequest("Title is required");

            await _taskService.AddTaskAsync(task);
            return CreatedAtAction(nameof(CreateTask), new { id = task.Id }, task);
        }
    }
}
