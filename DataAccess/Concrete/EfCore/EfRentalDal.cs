using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EfCore
{
    public class EfRentalDal : RepositoryBase<Rental, RentACarDbContext>, IRentalDal
    {
        public Rental? GetRentalByModelId(int id)
        {
            using (var context = new RentACarDbContext())
            {
                return  context.Rentals.Include(x => x.Model).FirstOrDefault(x => x.Model.Id == id);
            }
        }
    }
}