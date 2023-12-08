using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        Rental GetOneRental(int id);
        void SaveRental(Rental rental);

    }
}