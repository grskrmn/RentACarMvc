using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Extensions
{
    public static class ModelRepositoryExtension
    {

        
        public static IQueryable<Model> FilteredBrandName(this IQueryable<Model> models, string? brandName)
        {
             if(string.IsNullOrEmpty(brandName))
                return models;
            else
                return models.Include(x => x.Brand).Where(m => m.Brand.Name == brandName);
        }
        public static IQueryable<Model> FilteredColorName(this IQueryable<Model> models, string? colorName)
        {
             if(string.IsNullOrEmpty(colorName))
                return models;
            else
                return models.Include(x => x.Color).Where(m => m.Color.Name == colorName);
        }
        public static IQueryable<Model> FilteredBrandNameAndColorName(this IQueryable<Model> models, string? brandName, string? colorName)
        {
             if(string.IsNullOrEmpty(colorName))
                return models;
            else
                return models
                .Include(x => x.Color)
                .Include(x => x.Brand)
                .Where(m => m.Color.Name == colorName || m.Brand.Name  == brandName);
        }


        public static IQueryable<Model> FilteredBySearchTerm(this IQueryable<Model> models, string? searchTerm)
        {
             if(string.IsNullOrEmpty(searchTerm))
                return models;
            else
                return models
                .Include(x => x.Brand)
                .Include(x => x.Color)
                .Where(m 
                => m.Name.ToLower().Contains(searchTerm.ToLower()) 
                || m.Brand.Name.ToLower().Contains(searchTerm.ToLower())
                || m.Color.Name.ToLower().Contains(searchTerm.ToLower()) 
                || m.DailyPrice.ToString().ToLower().Contains(searchTerm.ToLower())
                );
        }

        public static IQueryable<Model> ToPaginate(this IQueryable<Model> models, int pageNumber, int pageSize)
        {
            return models.Skip((pageNumber -1)* pageSize).Take(pageSize);
        }
    }
}