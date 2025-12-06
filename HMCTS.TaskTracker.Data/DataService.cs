using HMCTS.TaskTracker.Data.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace HMCTS.TaskTracker.Data
{
    public static class DataService
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("TasksDb");
            services.AddDbContext<TaskDbContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
