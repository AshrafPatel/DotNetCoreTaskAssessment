using HMCTS.TaskTracker.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HMCTS.TaskTracker.Data.Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {
            
        }

        public DbSet<TaskEntity> Tasks { get; set; }
    }
}
