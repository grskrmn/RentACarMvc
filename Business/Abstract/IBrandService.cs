using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAllBrands();
    }
}/*
export PATH="${PATH}:${DOTNET_ROOT}"
export PATH="$PATH:$HOME/.dotnet/tools" */