using Microsoft.Extensions.DependencyInjection;

namespace DevTalk.Infrastructure.Extensions
{
    public static class InfraExtensions
    {
        public static void RegisterInfra(this IServiceCollection services)
        {
            services.AddScoped<IDevTalkInfra, DevTalkInfra>();
        }
    }
}
