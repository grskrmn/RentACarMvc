using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Model : BaseEntity
    {
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string? Name { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string? Description { get; set; }
        public int Capacity { get; set; }

        public IEnumerable<Rental> Rentals { get; set; }
        public Brand? Brand { get; set; }
        public Color? Color { get; set; }
    }
}