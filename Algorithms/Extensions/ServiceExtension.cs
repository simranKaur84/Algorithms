using AlgorithmServices.Sorting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServiceExtension(this IServiceCollection services) 
        {
            services.AddScoped<SortingAlgorithmService>();
            return services;
        }
    }
}
