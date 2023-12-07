using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.RequestParameters
{
    public class ModelRequestParameter : RequestParameter
    {
        
        public string? BrandName { get; set; }
        public string? ColorName { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        
        public ModelRequestParameter():this(1, 6)
        {
            
        }

        public ModelRequestParameter(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}