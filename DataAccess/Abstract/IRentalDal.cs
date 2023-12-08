using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IRepository<Rental>
    {
        Rental? GetRentalByModelId(int id);
    }
}