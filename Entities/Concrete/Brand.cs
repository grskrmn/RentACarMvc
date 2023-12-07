using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Brand : BaseEntity
    {
        public string? Name { get; set; }
        public IEnumerable<Model> Models { get; set; }
    }
}