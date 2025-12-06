using HMCTS.TaskTracker.Repositories.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace HMCTS.TaskTracker.Repositories
{
    public static class RepositoryServices
    {
        public static IServiceCollection AddRepoServices(this IServiceCollection services)
        {
            services.AddScoped<ITaskRepository, TaskRepository>();
            return services;
        }
    }
}
