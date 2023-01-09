using Bikes.Interface;
using Bikes.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBrosBikers
{
    public class StartupService
    {
        public static void AddService(IServiceCollection services)
        {
            services.AddScoped<IBike, BikeRepository>();
        }
    }
}
