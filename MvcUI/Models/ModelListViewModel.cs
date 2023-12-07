using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace MvcUI.Models
{
    public class ModelListViewModel
    {
        public IEnumerable<Model> Models { get; set; } = Enumerable.Empty<Model>();
        public Pagination Pagination { get; set; } = new();
        public int TotalCount => Models.Count();
    }
}