using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.RequestParameters;

namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        private readonly IModelDal _modelDal;

        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        public List<Model> GetAllModels()
        {
            return _modelDal.GetAllModelInclude();
        }

        public List<Model> GetAllModelsWithDetails(ModelRequestParameter parameter)
        {
            return _modelDal.GetAllModelsWithDetails(parameter);
        }
    }
}