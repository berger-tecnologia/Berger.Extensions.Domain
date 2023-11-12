using Berger.Extensions.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Berger.Extensions.Domain
{
    public static class BaseServiceConfiguration
    {
        public static void ConfigureBaseService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseService<>));
        }
    }
}