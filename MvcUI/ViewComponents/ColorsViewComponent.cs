using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents
{
    public class ColorsViewComponent: ViewComponent
    {
        private readonly IColorService _colorService;
        public ColorsViewComponent(IColorService colorService)
        {
            _colorService = colorService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_colorService.GetAllColors());
        }
    }
}