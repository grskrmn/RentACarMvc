using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Extensions;
using Entities.Concrete;
using Entities.RequestParameters;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EfCore
{
    public class EfModelDal : RepositoryBase<Model, RentACarDbContext>, IModelDal
    {
        public List<Model> GetAllModelInclude()
        {
            using (var context = new RentACarDbContext())
            {
                return context.Models.Include(x => x.Brand).Include(x => x.Color).ToList();
            }
        }

        public List<Model> GetAllModelsWithDetails(ModelRequestParameter modelRequest)
        {
            using (var context = new RentACarDbContext())
            {
                return context.Models
                .Include(x => x.Brand)
                .Include(x => x.Color)
                .FilteredBrandName(modelRequest.BrandName)
                .FilteredColorName(modelRequest.ColorName)
                .FilteredBySearchTerm(modelRequest.SearchTerm)
                .FilteredBrandNameAndColorName(modelRequest.BrandName, modelRequest.ColorName)
                .ToPaginate(modelRequest.PageNumber, modelRequest.PageSize)
                .ToList();
            }
        }
    }
}