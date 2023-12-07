using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;


namespace MvcUI.ViewComponents
{
    public class ShowcaseViewComponent:ViewComponent
    {
        private readonly IModelService _modelService;

        public ShowcaseViewComponent(IModelService modelService)
        {
            _modelService = modelService;
        }

        public IViewComponentResult Invoke()
        {
            var models = _modelService.GetAllModels().OrderByDescending(x => x.CreatedAt).Take(6).ToList();
            return View(models);
        }
    }
}