using System;
using Microsoft.Extensions.DependencyInjection;
using Adobe.Target.Client;

namespace TargetWrapperLibNet21
{
    public static class Class1
    {
        public static IServiceCollection AddAEMTarget(this IServiceCollection services)
        {
            services.AddTargetLibrary();
            return services;
        }
    }
}
