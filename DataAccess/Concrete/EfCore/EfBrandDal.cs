using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EfCore
{
    public class EfBrandDal: RepositoryBase<Brand, RentACarDbContext>, IBrandDal
    {
        
    }
}