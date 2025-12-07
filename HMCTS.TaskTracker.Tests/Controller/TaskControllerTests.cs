using HMCTS.TaskTracker.Api.Controllers;
using HMCTS.TaskTracker.Data.Data;
using HMCTS.TaskTracker.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Xunit;
using Assert = Xunit.Assert;

namespace HMCTS.TaskTracker.Tests.Api.Controller
{
    public class TaskControllerTests
    {
        [Fact]
        public async Task CreateTask_ShouldReturnBadRequest_WhenTitleIsMissing()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<TaskDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

            await using var context = new TaskDbContext(options);
            var controller = new HMCTS.TaskTracker.Api.Controllers.TaskController(context);

            var task = new TaskDto { Title = "", Status = Common.Enums.Status.Pending, DueDateTime = DateTime.UtcNow.AddDays(1) };

            // Act
            var result = await controller.CreateTask(task);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}
