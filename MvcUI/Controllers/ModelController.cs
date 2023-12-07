using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcUI.Models;

namespace MvcUI.Controllers
{
    public class ModelController : Controller
    {
        private readonly IModelService _service;

        public ModelController(IModelService service)
        {
            _service = service;
        }

        public IActionResult Index(ModelRequestParameter parameter)
        {
            var models = _service.GetAllModelsWithDetails(parameter);
            var pagination = new Pagination()
            {
                CurrentPage = parameter.PageNumber,
                ItemsPerPage = parameter.PageSize,
                TotalItems  = _service.GetAllModels().Count()
            };

            ModelListViewModel viewModel = new()
            {
                Models = models,
                Pagination = pagination
            };
            return View(viewModel);
        }
    }
}