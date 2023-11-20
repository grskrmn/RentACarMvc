using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EfCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.DepencyResolvers
{
    public static class DataAccessResolvers
    {
        public static void AddDataAccessDepencyResolvers(this IServiceCollection services)
        {
            services.AddScoped<IBrandDal, EfBrandDal>();
            services.AddScoped<IColorDal, EfColorDal>();
        }
    }
}