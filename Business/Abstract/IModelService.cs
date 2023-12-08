using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.RequestParameters;

namespace Business.Abstract
{
    public interface IModelService
    {
        List<Model> GetAllModels();
        Model GetModelById(int id);
        List<Model> GetAllModelsWithDetails(ModelRequestParameter parameter);
    }
}