using WebApplication1.Interfaces.StudentsInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication1.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            return services;
        }
    }
}
