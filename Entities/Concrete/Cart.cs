using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cart
    {
        public CartLine CartLine { get; set; }

        public Cart()
        {
            CartLine = new CartLine();
        }

        public virtual void CreateItem(Model model, DateTime startDate, DateTime endDate) 
        {
            CartLine = new CartLine()
            {
                Model = model,
                StartDate = startDate,
                EndDate = endDate
            };
        }

        public decimal ComputeTotalValue()
        {
            TimeSpan span = CartLine.EndDate - CartLine.StartDate;

            return span.Days;
        }
    }
}