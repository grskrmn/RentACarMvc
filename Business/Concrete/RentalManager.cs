using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal _rentalDal;
        public Rental GetOneRental(int id)
        {
            return _rentalDal.Get(x => x.Id == id);
        }

        public void SaveRental(Rental rental)
        {
            if(CheckIsModelRent(rental.Model.Id))
            {
                throw new Exception("Bu araç kirlanmıştır");
            }
            _rentalDal.Create(rental);
        }

        private  bool CheckIsModelRent(int modelId)
        {
            var rental = _rentalDal.GetRentalByModelId(modelId);
            if(rental?.RentEndDate is null)
                return true;
            else 
                return false;
            
        }

    }
}