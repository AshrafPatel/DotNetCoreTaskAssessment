using HMCTS.TaskTracker.Services.Profiles;
using HMCTS.TaskTracker.Services.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace HMCTS.TaskTracker.Services
{
    public static class AppServices
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg => {
                cfg.AddProfile<MapperConfig>();
            });

            services.AddScoped<ITaskService, TaskService>();
            return services;
        }
    }
}
