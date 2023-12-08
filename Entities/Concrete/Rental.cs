using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Identities;

namespace Entities.Concrete
{
    public class Rental : BaseEntity
    {
        public int ModelId { get; set; }
        public string? UserId { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Zip { get; set; }
        public DateTime RentedDate { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime? RentEndDate { get; set; }
        public bool Status { get; set; }

        public AppUser User { get; set; }
        public Model Model { get; set; }
    }
}