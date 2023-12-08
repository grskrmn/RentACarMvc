using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EfCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<IBrandDal, EfBrandDal>();
            services.AddScoped<IColorDal, EfColorDal>();
            services.AddScoped<IModelDal, EfModelDal>();
            services.AddScoped<IRentalDal, EfRentalDal>();
        }
        
    }
}