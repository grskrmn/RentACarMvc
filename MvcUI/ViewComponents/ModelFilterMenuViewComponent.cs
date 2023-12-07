using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents
{
    public class ModelFilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}