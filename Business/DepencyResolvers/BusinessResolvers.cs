using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Business.DepencyResolvers
{
    public static class BusinessResolvers
    {
        public static void AddBusinessDepencyResolvers(this IServiceCollection services)
        {
            services.AddScoped<IBrandService, BrandManager>();
            services.AddScoped<IColorService, ColorManager>();
        }
    }
}