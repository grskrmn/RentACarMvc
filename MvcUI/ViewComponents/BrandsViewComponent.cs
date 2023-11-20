using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents
{
    public class BrandsViewComponent:ViewComponent
    {
        private readonly IBrandService _brandService;
        public BrandsViewComponent(IBrandService brandService)
        {
            _brandService = brandService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_brandService.GetAllBrands());
        }
    }
}