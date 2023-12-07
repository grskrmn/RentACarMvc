using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;
using Entities.RequestParameters;

namespace DataAccess.Abstract
{
    public interface IModelDal : IRepository<Model>
    {
        List<Model> GetAllModelInclude();
        List<Model> GetAllModelsWithDetails(ModelRequestParameter modelRequest);
    }
}