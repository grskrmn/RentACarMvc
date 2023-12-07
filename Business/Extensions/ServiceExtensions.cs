using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IBrandService, BrandManager>();
            services.AddScoped<IColorService, ColorManager>();
            services.AddScoped<IModelService, ModelManager>();
        }
    }
}